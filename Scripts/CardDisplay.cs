using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using ElliottFrameworks;

public class CardDisplay : MonoBehaviour
{
    public Card cardData;

    public Image cardImage;
    public TMP_Text nameText;
    public TMP_Text healthText;
    public TMP_Text damageText;
    public Image[] typeImages;
    public Image damageImage;

    private Color[] cardColors = {
        new Color(0.7f, 0.25f, 0.25f), //Fire
        new Color(0.62f,0.4f, 0.17f), //Earth
        new Color(0.1f, 0.1f, 0.6f), //Water
        new Color(0.23f,0.06f,0.21f), //Dark
        new Color(0.8f,0.65f,0f), //Light
        new Color(0.7f,0.7f,0.85f) //Air
    };

    private Color[] typeColors = {
        new Color(0.85f, 0f, 0f), //Fire
        new Color(0.8f,0.52f, 0.24f), //Earth
        Color.blue, //Water
        new Color(0.47f,0.0f,0.4f), //Dark
        Color.yellow, //Light
        Color.white //Air
    };
    void Start()
    {
        UpdateCardDisplay();
    }

    public void UpdateCardDisplay()
    {
        //Update main card image color based on first card type
        cardImage.color = cardColors[(int)cardData.cardType[0]];

        //Update main card damage color based on first card type
        damageImage.color = typeColors[(int)cardData.damageType[0]];
        
        nameText.text = cardData.cardName;
        healthText.text = cardData.health.ToString();
        damageText.text = $"{cardData.damageMin} - {cardData.damageMax}";

        //Update type images
        for (int i=0; i<typeImages.Length; i++)
        {
            if(i< cardData.cardType.Count)
            {
                typeImages[i].gameObject.SetActive(true);
                typeImages[i].color = typeColors[(int)cardData.cardType[i]];

            }
            else
            {
                typeImages[i].gameObject.SetActive(false);
            }
        }   

        
    }
}
