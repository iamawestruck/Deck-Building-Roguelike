using System.Collections;
using System.Collections.Generic;
using ElliottFrameworks;
using UnityEngine;

public class DeckManager : MonoBehaviour
{
    public List<Card> allCards = new List<Card>();

    private int currentIndex = 0;

    public void DrawCard(HandManager handManager)
    {
        if(allCards.Count <=8){

            if(allCards.Count == 0){ return; }

            Card nextCard = allCards[currentIndex];
            handManager.AddCardToHand(nextCard);
            currentIndex = (currentIndex+1) % allCards.Count;
        }
    }

    void Start()
    {
        //Load all card assets from the Resources folder
        Card[] cards = Resources.LoadAll<Card>("Cards");

        //Add the loaded cards to the allCards list
        allCards.AddRange(cards);
    }
}
