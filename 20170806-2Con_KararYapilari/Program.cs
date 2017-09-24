using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170806_2Con_KararYapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Program her zaman tek düze hareket etmez. Bazen karar vermesi gerekir. 
             * Orn: kullanıcı adı ve parola girildi. öncelikle bunların doğruluğuna karar verilmesi gerekir. 
             * 2 tane karar yapısı vardır. Bunlar; 
             * 1- if-else
             * 2- switch-case
             * 
             * if else -> belli bir koşula bakarak komutun çalıştırılıp çalıştırılmayacağına karar vermeyi sağlayan yapıdır. Bu elemanların kendilerine ait blokları bulunur. 
             * 
             */

            Console.Write("Kullanıcı adınızı giriniz : ");
            string kadi = Console.ReadLine();
            Console.Write("Parola giriniz : ");
            string pass = Console.ReadLine();

            if (kadi == "hakan" & pass == "1234") // & sağ ve sol boolean alıyorsa kullanılabilir.
            {
                Console.WriteLine("Giriş başarılı. Hoşgeldin {0}",kadi); // formatlı yazmak daha iyi performans verir. eğer + " " + şeklinde kullanırsak daha düşük performans alırız.
            }
            else
            {
                Console.WriteLine("!! Kullanıcı adı veya parola hatalı");
            }
        }
    }
}
