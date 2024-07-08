using System;

namespace switch_case
{
    class Program
    {
        public static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                Console.WriteLine("Ocak Ayı");
                    break;
                case 2:
                Console.WriteLine("Subat Ayı");
                    break;
                case 3:
                Console.WriteLine("Mart Ayı");
                    break;
                case 4:
                Console.WriteLine("Nisan Ayı");
                    break;
                case 5:
                Console.WriteLine("Mayıs Ayı");
                    break;
                case 6:
                Console.WriteLine("Haziran Ayı");
                    break;
                case 7:
                Console.WriteLine("Temmuz Ayı");
                    break;
                default:
                Console.WriteLine("yanlis veri girdiniz");
                    break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                Console.WriteLine("kış ayındasınız");
                    break;
                case 3:
                case 4:
                case 5:
                Console.WriteLine("ilk bahardasınız");
                    break;

                case 6:
                case 7:
                case 8:
                Console.WriteLine("yaz ayındasınız");
                     break;
                default:
                Console.WriteLine("yanlış veri girdiniz");
                    break;
            }
            
            
        }
    }
}