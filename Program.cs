using System;

namespace KampİntroAsıl_başlangıç
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat yourself - kendini tekrarlama
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if(dolarDun>dolarBugun)
			{
                Console.WriteLine("Azalış butonu");
			}
            else if (dolarDun<dolarBugun)
			{
                Console.WriteLine("Artış Butonu");
			}



            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }


            Console.WriteLine(kategoriEtiketi);

        }
    }
}
