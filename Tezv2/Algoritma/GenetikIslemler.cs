using System;
using System.Collections.Generic;
using System.Linq;
using Tezv2.Models;

namespace Tezv2.Algoritma
{
    public class IterasyonDurumu
    {
        public int IterasyonNo { get; set; }
        public int HesaplamaSayisi { get; set; }
        public double EnIyiFitness { get; set; }
        public double AnlikMutasyonOrani { get; set; }
        public double AnlikCaprazlamaOrani { get; set; }
    }

    public class GenetikIslemler
    {
        // 1. ÇALIŞTIR
        public Kromozom Run(IProgress<IterasyonDurumu> ilerleme)
        {
            currentFitness = 0;
            _iterasyonSayisi = 0;

            Baslangic_populasyonunu_olustur();
            Fitness_hesapla();
            En_iyiyi_guncelle();

            while (!TerminationCondition())
            {
                _iterasyonSayisi += 1;
                AdaptifParametreleriGuncelle();

                Secim();
                Caprazlama();
                Mutasyon();
                Fitness_hesapla();
                En_iyiyi_guncelle();
                Elitism();

                if (ilerleme != null)
                {
                    ilerleme.Report(new IterasyonDurumu
                    {
                        IterasyonNo = _iterasyonSayisi,
                        HesaplamaSayisi = currentFitness,
                        EnIyiFitness = GlobalEnIyiCozum.Fitness,
                        AnlikMutasyonOrani = _mutasyonOrani,
                        AnlikCaprazlamaOrani = _caprazlamaOrani
                    });
                }
            }

            return GlobalEnIyiCozum;
        }

        // 2. ALGORİTMA OPERATÖRLERİ

        private bool TerminationCondition() // Durdurma Koşulu
        {
            if (GenetikAyarlar.IterasyonSinirli)
                return _iterasyonSayisi >= GenetikAyarlar.IterasyonSayisi;
            else
                return currentFitness >= GenetikAyarlar.UygunlukHesaplamaLimiti;
        }

        public void Baslangic_populasyonunu_olustur()
        {
            _populasyon = new List<Kromozom>();
            int uretilecek = _populasyonSayisi * 2; // Double Start
            var gecici = new List<Kromozom>();

            for (int i = 0; i < uretilecek; i++)
            {
                var birey = new Kromozom { Genler = SiralamayiTamamla(new List<IsModel>(), _tumIsler) };
                Degerlendir(birey);
                gecici.Add(birey);
            }
            _populasyon = gecici.OrderByDescending(x => x.Fitness).Take(_populasyonSayisi).ToList();
        }

        public void Secim()
        {
            // TURNUVA SEÇİMİ
            _secilenEbeveynler = new List<Kromozom>();
            for (int i = 0; i < _populasyonSayisi; i++)
            {
                Kromozom enIyiAday = null;
                for (int j = 0; j < _turnuvaBoyutu; j++) // Artık dinamik
                {
                    var aday = _populasyon[_rnd.Next(_populasyon.Count)];
                    if (enIyiAday == null || aday.Fitness > enIyiAday.Fitness)
                        enIyiAday = aday;
                }
                _secilenEbeveynler.Add(enIyiAday);
            }
        }

        public void Caprazlama()
        {
            _yeniNesil = new List<Kromozom>();

            // Seçilen ebeveynleri ikişer ikişer alıp çaprazlıyoruz
            for (int i = 0; i < _secilenEbeveynler.Count; i += 2)
            {
                // Eğer liste sonuna geldiysek ve tek ebeveyn kaldıysa aynen aktar
                if (i + 1 >= _secilenEbeveynler.Count)
                {
                    _yeniNesil.Add(_secilenEbeveynler[i].Kopyala());
                    break;
                }

                var baba = _secilenEbeveynler[i];
                var anne = _secilenEbeveynler[i + 1];

                // --- ERKEN YAKINSAMA (PREMATURE CONVERGENCE) MÜDAHALESİ ---
                // Ebeveynlerin aynı referans olup olmadığını veya gen dizilimlerinin tamamen aynı olup olmadığını kontrol et
                bool ebeveynlerAyni = (baba == anne);
                if (!ebeveynlerAyni)
                {
                    // Eğer referanslar farklıysa ama genetik dizilim birebir aynıysa yine erken yakınsama vardır
                    ebeveynlerAyni = baba.Genler.Select(x => x.ID).SequenceEqual(anne.Genler.Select(x => x.ID));
                }

                if (ebeveynlerAyni)
                {
                    // Ebeveynler aynıysa gen havuzunu ferahlatmak için Makro Mutasyon uyguluyoruz.
                    // Çocuk 1: Mevcut en iyi genetiği korumak için ebeveynin kopyası.
                    _yeniNesil.Add(baba.Kopyala());

                    // Çocuk 2 (Makro Mutasyon): Havuza tamamen sıfırdan, rastgele ama kısıtlara uygun "taze kan" sokuyoruz.
                    var tazeKan = new Kromozom
                    {
                        Genler = SiralamayiTamamla(new List<IsModel>(), _tumIsler), // Kısıtları bozmayan yeni rastgele dizilim
                        Fitness = 0 // Değerlendirme için sıfırlıyoruz
                    };
                    _yeniNesil.Add(tazeKan);

                    // Bu çift için işlemi tamamladık, standart çaprazlamayı atla ve sonraki çifte geç
                    continue;
                }
                // ----------------------------------------------------------

                // Çaprazlama Oranına göre işlem yap
                if (_rnd.NextDouble() <= (_caprazlamaOrani / 100.0))
                {
                    // --- CAPRAZLAMA MANTIĞI (Sıra Korumalı / Order Crossover) ---
                    int kesimNoktasi = _rnd.Next(1, _tumIsler.Count - 1);

                    // 1. Adım: Ebeveynlerin baş kısımlarını al
                    var c1_bas = baba.Genler.Take(kesimNoktasi).ToList();
                    var c2_bas = anne.Genler.Take(kesimNoktasi).ToList();

                    // HashSet ile arama hızını artırıyoruz (O(1) karmaşıklık)
                    var c1_idler = new HashSet<int>(c1_bas.Select(x => x.ID));
                    var c2_idler = new HashSet<int>(c2_bas.Select(x => x.ID));

                    // 2. Adım: Çocuk 1 için eksik genleri Anne'den (kendi sırasıyla) çek
                    var c1_kuyruk = anne.Genler.Where(x => !c1_idler.Contains(x.ID)).ToList();

                    // Çocuk 2 için eksik genleri Baba'dan (kendi sırasıyla) çek
                    var c2_kuyruk = baba.Genler.Where(x => !c2_idler.Contains(x.ID)).ToList();

                    // 3. Adım: Baş ve Kuyruk kısımlarını birleştirerek yeni bireyleri oluştur
                    var c1 = new Kromozom();
                    c1.Genler.AddRange(c1_bas);
                    c1.Genler.AddRange(c1_kuyruk);

                    var c2 = new Kromozom();
                    c2.Genler.AddRange(c2_bas);
                    c2.Genler.AddRange(c2_kuyruk);

                    _yeniNesil.Add(c1);
                    _yeniNesil.Add(c2);
                }
                else
                {
                    // Çaprazlama olmazsa ebeveynleri kopyala
                    _yeniNesil.Add(baba.Kopyala());
                    _yeniNesil.Add(anne.Kopyala());
                }
            }
        }
        public void Mutasyon()
        {
            foreach (var birey in _yeniNesil)
            {
                if (_rnd.NextDouble() < (_mutasyonOrani / 100.0))
                {
                    if (birey.Genler.Count < 3) continue;

                    // --- MUTASYON MANTIĞI (SSM) ---
                    int n1 = _rnd.Next(0, birey.Genler.Count);
                    int n2 = _rnd.Next(n1, birey.Genler.Count);

                    // Aralık sıfırsa (aynı sayıysa) düzelt
                    if (n1 == n2)
                    {
                        // n2 son indisten (Count - 1) küçükse bir sağa kaydır
                        if (n2 < birey.Genler.Count - 1)
                            n2++;
                        else
                            n1--; // n2 zaten son indisteyse, n1'i bir sola kaydırarak aralığı aç
                    }

                    var sol = birey.Genler.Take(n1).ToList();
                    var sag = birey.Genler.Skip(n2 + 1).ToList();

                    // Orta kısmı belirle
                    var ortaIDler = new HashSet<int>();
                    for (int i = n1; i <= n2; i++) ortaIDler.Add(birey.Genler[i].ID);

                    // Ortayı karıştırıp yeniden diz (Kısıtları koruyarak)
                    var yeniGenler = SiralamayiTamamlaKismi(sol, _tumIsler, ortaIDler);
                    yeniGenler.AddRange(sag);

                    birey.Genler = yeniGenler;

                    // Birey değiştiği için Fitness değerini sıfırla
                    birey.Fitness = 0;
                }
            }
        }

        public void Elitism()
        {
            // 1. Liste boşsa veya geçersizse işlem yapma
            if (_yeniNesil == null || _yeniNesil.Count == 0) return;

            // 2. O(N) karmaşıklığında, listenin tamamını tek seferde tarayarak 
            // en kötü fitness değerini ve onun indeksini buluyoruz.
            int enKotuIndex = 0;
            double enKotuFitness = _yeniNesil[0].Fitness;

            for (int i = 1; i < _yeniNesil.Count; i++)
            {
                if (_yeniNesil[i].Fitness < enKotuFitness)
                {
                    enKotuFitness = _yeniNesil[i].Fitness;
                    enKotuIndex = i;
                }
            }

            // 3. Bulduğumuz en kötü elemanı GlobalEnIyiCozum ile değiştiriyoruz.
            // O(N log N) sıralama maliyetinden kurtulduk, artık doğrudan hedefi değiştiriyoruz.
            _yeniNesil[enKotuIndex] = GlobalEnIyiCozum.Kopyala();

            // 4. Yeni nesli ana popülasyon yap.
            _populasyon = new List<Kromozom>(_yeniNesil);
        }
        public void Fitness_hesapla()
        {
            var hedef = (_yeniNesil != null && _yeniNesil.Count > 0) ? _yeniNesil : _populasyon;
            foreach (var birey in hedef)
            {
                if (birey.Fitness == 0) Degerlendir(birey);
            }
        }

        public void En_iyiyi_guncelle()
        {
            var hedef = (_yeniNesil != null && _yeniNesil.Count > 0) ? _yeniNesil : _populasyon;
            var nesilEnIyisi = hedef.OrderByDescending(x => x.Fitness).First();

            if (GlobalEnIyiCozum == null || nesilEnIyisi.Fitness > GlobalEnIyiCozum.Fitness)
            {
                GlobalEnIyiCozum = nesilEnIyisi.Kopyala();
            }
        }

        // 3. YARDIMCI METOTLAR (SIRALAMA VE HESAPLAMA)

        // Sıralamayı tamamla (başlangıç ve çaprazlama için)
        private List<IsModel> SiralamayiTamamla(List<IsModel> mevcut, List<IsModel> tum)
        {
            var sonuc = new List<IsModel>(mevcut);
            var idler = new HashSet<int>(mevcut.Select(x => x.ID));
            while (sonuc.Count < tum.Count)
            {
                var adaylar = UygunAdaylariBul(tum, idler);
                if (adaylar.Count == 0) break;
                var sec = adaylar[_rnd.Next(adaylar.Count)];
                sonuc.Add(sec); idler.Add(sec.ID);
            }
            return sonuc;
        }

        // Sıralamayı tamamla (mutasyon için)
        private List<IsModel> SiralamayiTamamlaKismi(List<IsModel> mevcut, List<IsModel> tum, HashSet<int> hedef)
        {
            var sonuc = new List<IsModel>(mevcut);
            var idler = new HashSet<int>(mevcut.Select(x => x.ID));
            int hedefSayi = mevcut.Count + hedef.Count;
            while (sonuc.Count < hedefSayi)
            {
                var adaylar = UygunAdaylariBul(tum, idler, hedef);
                if (adaylar.Count == 0) break;
                var sec = adaylar[_rnd.Next(adaylar.Count)];
                sonuc.Add(sec); idler.Add(sec.ID);
            }
            return sonuc;
        }

        // Öncüllük kısıtlarını sağlayan adayları bul
        private List<IsModel> UygunAdaylariBul(List<IsModel> tum, HashSet<int> eklenen, HashSet<int> kisit = null)
        {
            var adaylar = new List<IsModel>();
            foreach (var isModel in tum)
            {
                if (eklenen.Contains(isModel.ID)) continue;
                if (kisit != null && !kisit.Contains(isModel.ID)) continue;

                bool onculTamam = true;
                foreach (var onculId in isModel.OnculIDleri)
                {
                    if (!eklenen.Contains(onculId)) { onculTamam = false; break; }
                }
                if (onculTamam) adaylar.Add(isModel);
            }
            return adaylar;
        }

        // Fitness değerlendirme
        private void Degerlendir(Kromozom cozum)
        {
            // --- RAM & GARBAGE COLLECTOR OPTİMİZASYONU ---
            // Her değerlendirmede 'new List' oluşturmak yerine mevcut listeyi temizleyerek yeniden kullanıyoruz.
            if (cozum.Istasyonlar == null)
            {
                cozum.Istasyonlar = new List<IstasyonModel>();
            }
            else
            {
                cozum.Istasyonlar.Clear();
            }

            int istasyonSayac = 1;
            var aktif = new IstasyonModel { IstasyonNo = istasyonSayac };

            // Alt nesnelerin de yeniden kullanımını garanti ediyoruz
            if (aktif.AtananIsler == null) aktif.AtananIsler = new List<IsModel>();
            else aktif.AtananIsler.Clear();

            cozum.Istasyonlar.Add(aktif);

            foreach (var isModel in cozum.Genler)
            {
                if (aktif.ToplamSure + isModel.Sure <= _hedefSure)
                {
                    aktif.AtananIsler.Add(isModel);
                    aktif.ToplamSure += isModel.Sure;
                }
                else
                {
                    istasyonSayac++;
                    aktif = new IstasyonModel { IstasyonNo = istasyonSayac };
                    if (aktif.AtananIsler == null) aktif.AtananIsler = new List<IsModel>();

                    aktif.AtananIsler.Add(isModel);
                    aktif.ToplamSure = isModel.Sure;
                    cozum.Istasyonlar.Add(aktif);
                }
            }

            // --- METRİK HESAPLAMALARI ---
            cozum.IstasyonSayisi = cozum.Istasyonlar.Count;
            cozum.GercekCevrimSuresi = cozum.Istasyonlar.Max(x => x.ToplamSure);

            double refCevrim = Math.Max(_hedefSure, cozum.GercekCevrimSuresi);
            double toplamIs = cozum.Istasyonlar.Sum(x => x.ToplamSure);

            double kapasite = cozum.IstasyonSayisi * refCevrim;
            cozum.HatVerimliligi = (kapasite == 0) ? 0 : (toplamIs / kapasite) * 100;

            double siKareler = cozum.Istasyonlar.Sum(st => Math.Pow(refCevrim - st.ToplamSure, 2));
            cozum.SI = Math.Sqrt(siKareler);

            cozum.Fitness = (0.6 * (cozum.HatVerimliligi / 100.0)) + (0.4 * (refCevrim / (refCevrim + cozum.SI)));

            currentFitness++;
        }
        public void AdaptifParametreleriGuncelle()
        {
            // SADECE Adaptif ayar kapalıysa çık (Iterasyon kısıtlamasını kaldırdık)
            if (!GenetikAyarlar.AdaptifParametre)
            {
                return;
            }

            // --- İlerleme Oranını Hangi Modda Olduğumuza Göre Dinamik Hesapla ---
            double ilerlemeOrani = 0;

            if (GenetikAyarlar.IterasyonSinirli)
            {
                // İterasyon modundaysak, iterasyon hedefine ne kadar yaklaştığımıza bak
                ilerlemeOrani = (double)_iterasyonSayisi / GenetikAyarlar.IterasyonSayisi;
            }
            else
            {
                // Uygunluk (Evaluation) modundaysak, uygunluk hedefine ne kadar yaklaştığımıza bak
                ilerlemeOrani = (double)currentFitness / GenetikAyarlar.UygunlukHesaplamaLimiti;
            }

            // İlerleme oranının matematiksel olarak %100'ü (1.0) geçmesini engelle (Güvenlik)
            if (ilerlemeOrani > 1.0) ilerlemeOrani = 1.0;

            // Çaprazlama Oranı (Artan)
            double hedefCaprazlama = 95.0;
            if (_baslangicCaprazlamaOrani < hedefCaprazlama)
            {
                _caprazlamaOrani = _baslangicCaprazlamaOrani + ((hedefCaprazlama - _baslangicCaprazlamaOrani) * ilerlemeOrani);
            }

            // Mutasyon Oranı (Azalan)
            double hedefMutasyon = 1.0;
            if (_baslangicMutasyonOrani > hedefMutasyon)
            {
                _mutasyonOrani = _baslangicMutasyonOrani - ((_baslangicMutasyonOrani - hedefMutasyon) * ilerlemeOrani);
            }
        }
        // 4. DEĞİŞKENLER VE KURUCU METOT

        public List<IsModel> _tumIsler;
        public double _hedefSure;
        public int _populasyonSayisi;
        public double _caprazlamaOrani;
        public double _mutasyonOrani;
        public int _turnuvaBoyutu;
        public double _baslangicCaprazlamaOrani;
        public double _baslangicMutasyonOrani;
        public Random _rnd;

        public int _iterasyonSayisi;
        public int currentFitness;

        public List<Kromozom> _populasyon;
        public List<Kromozom> _secilenEbeveynler;
        public List<Kromozom> _yeniNesil;
        public Kromozom GlobalEnIyiCozum { get; set; }

        public GenetikIslemler(List<IsModel> tumIsler, double hedefSure,
                               int populasyonSayisi, double caprazlamaOrani,
                               double mutasyonOrani, int turnuvaBoyutu, int? seed = null)
        {
            _tumIsler = tumIsler;
            _hedefSure = hedefSure;
            _populasyonSayisi = populasyonSayisi;
            _caprazlamaOrani = caprazlamaOrani;
            _mutasyonOrani = mutasyonOrani;
            _turnuvaBoyutu = turnuvaBoyutu;
            _baslangicCaprazlamaOrani = caprazlamaOrani;
            _baslangicMutasyonOrani = mutasyonOrani;

            _rnd = seed.HasValue ? new Random(seed.Value) : new Random();
        }
    }
}