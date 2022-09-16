using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr1
{
    internal class Converter
    {
        private int usd;
        private int eur;
        private int uah;
        private const float courseUsd = 36.92F;
        private const float courseEur = 36.94F;

        public Converter(int usd, int eur, int uah)
        {
            this.usd = usd;
            this.eur = eur;
            this.uah = uah;
        }

        public static void help()
        {
            Console.WriteLine("1 = uah to usd");
            Console.WriteLine("2 = uah to eur");
            Console.WriteLine("3 = usd to uah");
            Console.WriteLine("4 = usd to eur");
            Console.WriteLine("5 = eur to uah");
            Console.WriteLine("6 = eur to usd");
        }
        public int Convert(int valute, double money)
        {

            switch (valute){
                case 1:
                    return (int)(money / courseUsd);
                case 2:
                    return(int)(money / courseEur);
                case 3:
                    return (int)(money * courseUsd);
                case 4:
                    return (int)(money / (courseEur - courseUsd));
                case 5:
                    return (int)(money * courseEur);
                case 6:
                    return (int)(money * (courseEur - courseUsd));
                default:
                    return -1;
                    help();
                    
            }
        }
    }
}
