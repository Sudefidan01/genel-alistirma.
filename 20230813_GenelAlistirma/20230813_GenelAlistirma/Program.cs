using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230813_GenelAlistirma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Soru 1 
            //Kullanıcıdan 5 adet sayı talep edelim
            //Girilen sayıların ortalaması çift ise "Girilen Sayıların ortalaması çifttir " , tek ise "Girilen sayıların ortalaması tektir" mesajını gösterelim
            int[] sayilar=new int[5];
            int toplam = 0;
            double ortalama;

            for (int i = 0; i <sayilar.Length; i++)
            {
                Console.Clear();
                Console.Write((i+1)+".Sayıyı Giriniz : ");
                sayilar[i]=int.Parse(Console.ReadLine());
                toplam += sayilar[i];
            }
            ortalama =toplam /sayilar.Length;
            
            if (ortalama %2 ==0)
            {
                Console.WriteLine("Girilen Sayıların Ortalaması Çifttir = "+ortalama);
            }
            else
            {
                Console.WriteLine("Girilen Sayıların Ortalaması Tektir = " + ortalama);

            }

            Console.ReadKey();
        }
    }
}
