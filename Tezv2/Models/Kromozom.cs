using System.Collections.Generic;

namespace Tezv2.Models
{
    public class Kromozom
    {
        public List<IsModel> Genler { get; set; } = new List<IsModel>();
        public List<IstasyonModel> Istasyonlar { get; set; } = new List<IstasyonModel>();

        // Metrikler
        public double Fitness { get; set; }
        public double HatVerimliligi { get; set; }
        public double SI { get; set; }
        public double GercekCevrimSuresi { get; set; }
        public int IstasyonSayisi { get; set; }

        public Kromozom Kopyala()
        {
            Kromozom kopya = new Kromozom();

            // Genleri Kopyala
            if (this.Genler != null)
                kopya.Genler = new List<IsModel>(this.Genler);

            // İstasyonları Kopyalama
            if (this.Istasyonlar != null)
            {
                kopya.Istasyonlar = new List<IstasyonModel>();
                foreach (var ist in this.Istasyonlar)
                {
                    IstasyonModel yeniIst = new IstasyonModel
                    {
                        IstasyonNo = ist.IstasyonNo,
                        ToplamSure = ist.ToplamSure,
                        AtananIsler = new List<IsModel>(ist.AtananIsler)
                    };
                    kopya.Istasyonlar.Add(yeniIst);
                }
            }

            // Değerleri Aktar
            kopya.Fitness = this.Fitness;
            kopya.HatVerimliligi = this.HatVerimliligi;
            kopya.SI = this.SI;
            kopya.IstasyonSayisi = this.IstasyonSayisi;
            kopya.GercekCevrimSuresi = this.GercekCevrimSuresi;

            return kopya;
        }
    }
}