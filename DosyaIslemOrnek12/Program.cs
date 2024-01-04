using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DosyaIslemOrnek12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String secim="", veri;
            do
            {
                Console.Clear();
                Console.WriteLine("Kayıt(K),Listele(L),Verileri Sil(S),Çıkış(E)");
                secim = Console.ReadLine();
                if(secim=="K")
                {
                    Console.WriteLine("Kaydedilecek veriyi gir:");
                    veri= Console.ReadLine();   
                    File.AppendAllText("kayit.txt",veri);
                    Console.WriteLine("Kaydedildi");
                    Console.ReadLine();
                }
                else if(secim=="L")
                {
                    if (File.Exists("kayit.txt") == true)
                    {
                        veri = File.ReadAllText("kayit.txt");
                        Console.WriteLine(veri);
                    }
                    else
                    {
                        Console.WriteLine("Dosya bulunamadı");
                    }
                    Console.ReadLine();

                }
                else if(secim=="S")
                {
                    File.Delete("kayit.txt");
                    Console.WriteLine("Veriler silindi");
                    Console.ReadLine();
                }


            } while (secim != "E");
            
        }
    }
}
