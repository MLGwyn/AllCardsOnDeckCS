using System;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var suits = new List<string>() { "Hearts", "Clubs", "Diamonds", "Spade" };
            var ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            var deckOfCards = new List<string>();

            for (var deckOfCardsCount = 0; deckOfCardsCount < 2; deckOfCardsCount++)
            {

                foreach (var currentSuit in suits)
                {
                    foreach (var currentRank in ranks)
                    {
                        deckOfCards.Add($"{currentRank} of {currentSuit}");
                    }
                }
            }

            var numberOfCards = deckOfCards.Count;

            for (var rightIndex = numberOfCards - 1; rightIndex > 0; rightIndex--)
            {
                var randomNumberGenerator = new Random();
                var leftIndex = randomNumberGenerator.Next(rightIndex);
                var leftCard = deckOfCards[leftIndex];
                var rightCard = deckOfCards[rightIndex];
                deckOfCards[rightIndex] = leftCard;
                deckOfCards[leftIndex] = rightCard;
            }

            Console.WriteLine($"The top two cards are {deckOfCards[0]} and {deckOfCards[1]} ");
            Console.WriteLine($"There are {deckOfCards.Count} cards in the deck.");






        }
    }
}
