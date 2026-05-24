namespace Tezv2
{
    public static class GenetikAyarlar
    {
        public static int TurnuvaBoyutu { get; set; } = 5;
        public static int PopulasyonBuyuklugu { get; set; } = 200;
        public static double MutasyonOrani { get; set; } = 5.0;
        public static double CaprazlamaOrani { get; set; } = 90.0;
        public static bool AdaptifParametre { get; set; } = true;

        // True: İterasyon Sayısı ile durur
        // False: Uygunluk Hesaplama Sayısı ile durur
        public static bool IterasyonSinirli { get; set; } = true;
        public static int IterasyonSayisi { get; set; } = 1000;
        public static int UygunlukHesaplamaLimiti { get; set; } = 10000;
    }
}