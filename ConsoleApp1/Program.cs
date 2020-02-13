using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            
            int maas = 2750;

uint sicaklik = 29;

long agirlik = 1500;

ulong arac_fiyat = 25600;

float pirilanta_agirlik = 15.684f;

double pirlanta_fiyati1 = 15.684;

decimal pirlanta_fiyati2 = 15.74m;

bool cevap = true;

char menu = '1';
   
        /*
 * ÇOKLU YORUM
 */
        // TEKLİ YORUM
        // ctrl + K + D => Kodaları Düzenle 
        // ctrl + E + W 
        // ctrl + K + C => Yorum satırına al
        // ctrl + K + U => Yorum satırından al
        // ctrl + D + n => dublecate 
        // Tam Sayılar
        // byte,sbyte,short, ushort,int,uint,long,ulong

        // byte => 8 bit
        // MaxValue => 127 bit
        // MinValue => -128

        sbyte sayi1 = 12;

        //ushort => 16 bit
        //MixValue = 65535
        //MinValue = 0
        short sayi3 = 123;

        // int => 32 bit
        // MaxValue = 2147483647
        // Min Value = -2147483648
        int sayi5 = 324;

        // long => 64 bit 
        // MaxValue = 9223372036854775807
        // MinValue = -9223372036854775808
        long sayi7 = 324234;



        // ondalıklı sayılar 
        // float,double,decimal

        // Metinsel 
        // char, string

        // Mantıksal 
        //bool 


        ulong sayi8 = 23424;

        float sayi9 = 12.0F;

        double sayi10 = 12.0;
        decimal sayi11 = 12.0M;

        // char => 16 bit
        char karakter = 'A';
        //string
        string metin1 = "Bilge Adam Beşiktaş Yazılım Dersleri";
            // \n => yeni bir satır oluşturur 
            // \t => bir tab boşluk
        string tekKarakter = "A";
        Console.WriteLine(metin1);

            string tabBosluk = "bilge\tAdam";
            Console.WriteLine(tabBosluk);

         string metin2 = "Bilge Adam Besiktas \"Yazılım\" Dersleri ";
          Console.WriteLine(metin2);

            bool sonuc = false;
            bool result = 10 > 2;
            Console.WriteLine(result);

            Console.ReadKey();
        }
        }
    }





