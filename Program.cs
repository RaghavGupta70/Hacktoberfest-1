using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCards;

namespace ProgrammingAssignment2
{
    
    /// <summary>
    /// Programming Assignment 2
    /// </summary>
    class Program
    {
        /// <summary>
        /// Implements Nothing Like Blackjack functionality
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // loop while there's more input
            //Use proprer input function to get value in the string input
            string input;
            while (input[0] != 'q')
            {

                // Add your code between this comment
                // and the comment below. You can of
                // course add more space between the
                // comments as needed

                // declare a deck variables and create a deck object
                // DON'T SHUFFLE THE DECK
                Deck deck = new Deck();

                // deal 2 cards each to 4 players (deal properly, dealing
                // the first card to each player before dealing the
                // second card to each player)
                Card card00 =  deck.TakeTopCard();
                Card card10 = deck.TakeTopCard();
                Card card20 = deck.TakeTopCard();
                Card card30 = deck.TakeTopCard();

                Card card01 = deck.TakeTopCard();
                Card card11 = deck.TakeTopCard();
                Card card21 = deck.TakeTopCard();
                Card card31 = deck.TakeTopCard();



                // deal 1 more card to players 2 and 3

                Card card12 = deck.TakeTopCard();

                Card card22 = deck.TakeTopCard();

                // flip all the cards over
                card00.FlipOver();
                card01.FlipOver();

                card10.FlipOver();
                card11.FlipOver();
                card12.FlipOver();

                card20.FlipOver();
                card21.FlipOver();
                card22.FlipOver();

                card30.FlipOver();
                card31.FlipOver();




                // print the cards for player 1
              
                Console.WriteLine(card00.Rank + "," + card00.Suit);
                Console.WriteLine(card01.Rank + "," + card01.Suit);
           
                // print the cards for player 2
              
                Console.WriteLine(card10.Rank + "," + card10.Suit);
                Console.WriteLine(card11.Rank + "," + card11.Suit);
                Console.WriteLine(card12.Rank + "," + card12.Suit);
                

                // print the cards for player 3
               
                Console.WriteLine(card20.Rank + "," + card20.Suit);
                Console.WriteLine(card21.Rank + "," + card21.Suit);
                Console.WriteLine(card22.Rank + "," + card22.Suit);
                

                // print the cards for player 4
               

                Console.WriteLine(card30.Rank + "," + card30.Suit);
                Console.WriteLine(card31.Rank + "," + card31.Suit);
             
                // Don't add or modify any code below
                // this comment
                input = Console.ReadLine();
            }
        }
    }
}
