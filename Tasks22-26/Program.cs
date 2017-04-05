using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks22_26
{
    class Program
    {
        struct Card
        {
            public Suits Suit;
            public Growths Growth;        }
        enum Suits
        {
            Spades,
            Clubs,
            Diamonds,
            Hearts
        }
        enum Growths
        {
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            Ace
        }
        static Card[] arrCards;
        static void Main(string[] args)
        {
            arrCards = new Card[]{
                new Card() {Suit = Suits.Spades, Growth = Growths.Six},
                new Card() {Suit = Suits.Spades, Growth = Growths.Seven},
                new Card() {Suit = Suits.Spades, Growth = Growths.Eight},
                new Card() {Suit = Suits.Spades, Growth = Growths.Nine},
                new Card() {Suit = Suits.Spades, Growth = Growths.Ten},
                new Card() {Suit = Suits.Spades, Growth = Growths.Jack},
                new Card() {Suit = Suits.Spades, Growth = Growths.Queen},
                new Card() {Suit = Suits.Spades, Growth = Growths.King},
                new Card() {Suit = Suits.Spades, Growth = Growths.Ace},
                //*****************************************************
                new Card() {Suit = Suits.Clubs, Growth = Growths.Six},
                new Card() {Suit = Suits.Clubs, Growth = Growths.Seven},
                new Card() {Suit = Suits.Clubs, Growth = Growths.Eight},
                new Card() {Suit = Suits.Clubs, Growth = Growths.Nine},
                new Card() {Suit = Suits.Clubs, Growth = Growths.Ten},
                new Card() {Suit = Suits.Clubs, Growth = Growths.Jack},
                new Card() {Suit = Suits.Clubs, Growth = Growths.Queen},
                new Card() {Suit = Suits.Clubs, Growth = Growths.King},
                new Card() {Suit = Suits.Clubs, Growth = Growths.Ace},
                //*****************************************************
                new Card() {Suit = Suits.Diamonds, Growth = Growths.Six},
                new Card() {Suit = Suits.Diamonds, Growth = Growths.Seven},
                new Card() {Suit = Suits.Diamonds, Growth = Growths.Eight},
                new Card() {Suit = Suits.Diamonds, Growth = Growths.Nine},
                new Card() {Suit = Suits.Diamonds, Growth = Growths.Ten},
                new Card() {Suit = Suits.Diamonds, Growth = Growths.Jack},
                new Card() {Suit = Suits.Diamonds, Growth = Growths.Queen},
                new Card() {Suit = Suits.Diamonds, Growth = Growths.King},
                new Card() {Suit = Suits.Diamonds, Growth = Growths.Ace},
                //*****************************************************
                new Card() {Suit = Suits.Hearts, Growth = Growths.Six},
                new Card() {Suit = Suits.Hearts, Growth = Growths.Seven},
                new Card() {Suit = Suits.Hearts, Growth = Growths.Eight},
                new Card() {Suit = Suits.Hearts, Growth = Growths.Nine},
                new Card() {Suit = Suits.Hearts, Growth = Growths.Ten},
                new Card() {Suit = Suits.Hearts, Growth = Growths.Jack},
                new Card() {Suit = Suits.Hearts, Growth = Growths.Queen},
                new Card() {Suit = Suits.Hearts, Growth = Growths.King},
                new Card() {Suit = Suits.Hearts, Growth = Growths.Ace},
                //*****************************************************
            };
            shuffleArray(arrCards);
            
            /*for (int i = 0; i < arrCards.Length; i++)
            {
                if(arrCards[i].Growth == Growths.Ace)
                {
                    Console.WriteLine("Pos of " + arrCards[i].Suit +"'s ace =" + i);
                }
            }*/
            int startIndex = 0;
            for (int i = 0; i < arrCards.Length; i++)
            {
                if(arrCards[i].Suit == Suits.Spades)
                {
                    if (arrCards[startIndex].Suit != Suits.Spades)
                    {                 
                        Card tmp = arrCards[startIndex];
                        arrCards[startIndex] = arrCards[i];
                        arrCards[i] = tmp;                       
                    }
                    startIndex++;
                }
            }
            for (int i = 0; i < arrCards.Length; i++)
            {
                Console.WriteLine(arrCards[i].Suit + "-" + arrCards[i].Growth);
            }
        }
        static void shuffleArray(Card[] arr)
        {
            Random rnd = new Random();
            int i = arr.Length-1;
            while (i > 0)
            {
                int index = rnd.Next(--i);
                Card tmp = arr[i + 1];
                arr[i + 1] = arr[index];
                arr[index] = tmp;
            }
        }
    }
}
