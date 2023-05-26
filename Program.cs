using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yenidensişarp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1000;
            string seçim=Console.ReadLine();

            if(seçim=="1")
            {
                Console.WriteLine(bakiye);
                Console.WriteLine();
            }
             
            else if(seçim=="2")
            {
                Console.WriteLine("çekmek istediğin tutarı gir");
                int tutar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("bakiye= "+(bakiye-tutar));   
                Console.ReadLine(); 
            }
            else if(seçim=="3")
            {
                Console.WriteLine("yatırmak istediğiniz tutarı giriniz");
                int yatır = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("bakiye= "+(bakiye + yatır));
                Console.ReadLine();
            }
            else if(seçim=="q")
            {
                Console.WriteLine("çıkış yapılıyor");
                Console.ReadLine(); 
            }
            else

            {
                Console.WriteLine("lütfen doğru tuşlamayı yapınız");
                Console.ReadLine(); 
            }
        }
    }
}
