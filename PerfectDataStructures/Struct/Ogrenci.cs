namespace PerfectDataStructures
{
    
    public struct Ogrenci 
    {
        
        
       public Ogrenci(int numara, string ad, string soyad, bool cinsiyet)  
        {
            Numara = numara;
            Ad = ad;
            Soyad = soyad;
            Cinsiyet = cinsiyet;
        }

        public int Numara { get; set; } 
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public bool Cinsiyet { get; set; }

        

        public override string ToString()
        {
            return $"{Numara , -5}" + $"{Ad,-10}" + $"{Soyad,-10}" + string.Format("{0,5}" , Cinsiyet == true ? "Erkek" : "Kadın" );
        }

    }
}
