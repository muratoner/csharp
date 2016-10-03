using System;

namespace MHG.CustomAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            TestYazarOzelligi.Test();
            Console.ReadKey();
        }
    }

    // Çoklu kullanım özelliği.
    [System.AttributeUsage(System.AttributeTargets.Class |
                           System.AttributeTargets.Struct,
                           AllowMultiple = true)  // Çoklu kullanım özelliği.
    ]
    public class Yazar : System.Attribute
    {
        string ad;
        public double versiyon;

        public Yazar(string ad)
        {
            this.ad = ad;

            // Varsayılan Değer.
            versiyon = 1.0;
        }

        public string AdGetir()
        {
            return ad;
        }
    }

    // Author özelliğine sahip sınıf.
    [Yazar("Murat ÖNER")]
    public class BirinciSinif
    {
        // ...
    }

    // Author özelliği olmayan sınıf.
    public class IkinciSinif
    {
        // ...
    }

    // Çoklu author özelliğine sahip sınıf.
    [Yazar("Sakine Salmanlı"), Yazar("Ramazan Öner", versiyon = 2.0)]
    public class UcuncuSinif
    {
        // ...
    }

    class TestYazarOzelligi
    {
        public static void Test()
        {
            YazarBilgisiYazdir(typeof(BirinciSinif));
            YazarBilgisiYazdir(typeof(IkinciSinif));
            YazarBilgisiYazdir(typeof(UcuncuSinif));
        }

        private static void YazarBilgisiYazdir(System.Type t)
        {
            System.Console.WriteLine("{0} Yazar Bilgisi", t);

            // Reflection kullanımı.
            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(t);  // Reflection.

            // Çıktı Gösterimi.
            foreach (System.Attribute attr in attrs)
            {
                if (attr is Yazar)
                {
                    Yazar a = (Yazar)attr;
                    System.Console.WriteLine("   {0}, versiyon {1:f}", a.AdGetir(), a.versiyon);
                }
            }
        }
    }
    /* Çıktı:
        MHG.CustomAttribute.BirinciSinif Yazar Bilgisi
           Murat ÖNER, versiyon 1.00
        MHG.CustomAttribute.IkinciSinif Yazar Bilgisi
        MHG.CustomAttribute.UcunsuSinif Yazar Bilgisi
           Sakine Salmanlı, versiyon 1.00
           Ramazan Öner, versiyon 1.00
    */
}