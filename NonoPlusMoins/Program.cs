using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonoPlusMoins
{
    class Program
    {
        const int MIN_VALUE = 0;
        const int MAX_VALUE = 100;

        static void Main(string[] args)
        {
            programme();
        }

        private static void programme()
        {
            bool find = false;
            int num;
            var rand = new Random();
            int input;
            int nbEssais = 0;
            String rawInput;

            DisplayMessage("Tirage du nombre");
            num = rand.Next(MIN_VALUE, MAX_VALUE);

            do
            {
                DisplayMessage("Entrez un nombre");
                rawInput = Console.ReadLine();

                try
                {
                    nbEssais ++;
                    input = Int32.Parse(rawInput);
                }
                catch (Exception)
                {
                    DisplayMessage("Crétin un chiffre, ça comptera quand meme pour un tour");
                    input = Int32.MinValue;
                }
                if (input > num){ DisplayMessage("le nombre a trouver est plus petit"); }
                else { DisplayMessage("le nombre a trouver est plus grand"); }
                find = input == num;
            } while (!find);
            DisplayMessage("gagné");
        }

        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        private void Programme2()
        {

        }
    }
}
