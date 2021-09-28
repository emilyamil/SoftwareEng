using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;

public class BlackJack : MonoBehaviour
{
    /* // Start is called before the first frame update
       string Suit;
     string Rank;
     //int cardsLeftInDeck = 52;
     public TMP_Text currentHand;
     public string currentHands;
     public TMP_Text AIHand;
     public string AIHands;
     public Random Randomizer { get; set; }
     //public Card[] Cards { get; set; }

     public void Start()
     {
         currentHand.text = "0";
         AIHand.text = "0";
         //makeDeck();
     }

     public void Update()
     {
     }
     /*
     public async Card DrawCard()
     {
         if (cardsLeftInDeck == 0)
         {
             return;
         }
         int rnd;
         do 
         {
             rnd = Randomizer.Next(0, 52);
         } while (Cards[rnd] == null);
         Card drawnCard = Cards[rnd];
         Cards[rnd] = null; // "remove" card from deck
         cardsLeftInDeck -= 1;
         symbol1.text = ran1.ToString();
         symbol1s = symbol1.ToString();
         return drawnCard;
     }


     public async void Stay()
     {

     }

     public void Card(string suit, string rank)  
     {
         for (int i = 0; i < 4; i++)   //assign suit to card
         {
             if (ValidSuits()[i] == suit)
             {
                 Suit = suit;
                 break;
             }
         }
         for (int i = 0; i < 13; i++)  //assign rank to card
         {
             if (ValidRanks()[i] == rank)
             {
                 Rank = rank;
                 break;
             }
         }
     }

     public static string[] ValidSuits()
     {
         string[] validSuitArray = new string[4]
         { "Hearts", "Spades", "Diamonds", "Clubs" };
         return validSuitArray;
     }

     public static string[] ValidRanks()
     {
         string[] validRankArray = new string[13]
            {"Ace", "2", "3", "4", "5", "6", "7", "8", "9",
             "10", "Jack", "Queen", "King"};
         return validRankArray;
     }

     public int GetValue()   // method to return value of a card
     {
         switch (this.Rank)
         {
             case "Ace": return 1;
             case "2": return 2;
             case "3": return 3;
             case "4": return 4;
             case "5": return 5;
             case "6": return 6;
             case "7": return 7;
             case "8": return 8;
             case "9": return 9;
             default: return 10;
         }
     }

     public void makeDeck() 
     {
         Cards = new Card[52];
         int cardsPos = 0;
         foreach (string rank in Card.ValidRanks())
         {
             foreach (string suit in Card.ValidSuits())
             {
                 Cards[cardsPos++] = new Card(suit, rank);
             }
         }
         Randomizer = new Random();

     }*/
}
