using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of cards to pick: ");

            string line = Console.ReadLine();

            if (int.TryParse(line, out int numberOfCards))
            {
                string[] Cards = CardPicker.PickSomeCards(numberOfCards);

                foreach (string card in Cards)
                {
                    Console.WriteLine("You have drawn a " + card);
                }
            }
            else
            {
                Console.WriteLine("Sorry, number was not valid.");
            };
        }
    }
}
