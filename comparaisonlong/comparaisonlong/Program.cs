using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparaisonlongueur
{
    class Program
    {

        public static bool comparerchaine(string p_chaine1, string p_chaine2)
        {
            if (p_chaine1.Length == p_chaine2.Length)
                return true;
            else return false;


        }
        static void Main(string[] args)
        {
            Console.WriteLine(comparerchaine("hasnaa", "Didier"));
            Console.WriteLine(comparerchaine("hasnaa", "Didiere"));
            Console.ReadLine();
        }
    }
}
