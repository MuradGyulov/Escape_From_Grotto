using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Book : MonoBehaviour
{
    [SerializeField] int MaxOffers;
    [SerializeField] GameObject Player;

    private int clickCounter;

    [SerializeField] Text text;

    [Header("Russian Offers")]
    [SerializeField] string RU1;
    [SerializeField] string RU2;
    [SerializeField] string RU3;
    [SerializeField] string RU4;
    [SerializeField] string RU5;
    [SerializeField] string RU6;

    [Header("English Offers")]
    [SerializeField] string EN1;
    [SerializeField] string EN2;
    [SerializeField] string EN3;
    [SerializeField] string EN4;
    [SerializeField] string EN5;
    [SerializeField] string EN6;

    [Header("Turkish Offers")]
    [SerializeField] string TU1;
    [SerializeField] string TU2;
    [SerializeField] string TU3;
    [SerializeField] string TU4;
    [SerializeField] string TU5;
    [SerializeField] string TU6;

    private enum Language { Russian, English, Turkish}; Language currentLanguage;


    private void Start()
    {
        if(Application.systemLanguage == SystemLanguage.Russian)
        {
            currentLanguage = Language.Russian;
        }
        else if(Application.systemLanguage == SystemLanguage.English)
        {
            currentLanguage = Language.English;
        }
        else if (Application.systemLanguage == SystemLanguage.Turkish)
        {
            currentLanguage = Language.Turkish;
        }
        else
        {
            currentLanguage = Language.English;
        }

        LoadNextText();
    }

    public void LoadNextText()
    {
        clickCounter++;
        if(clickCounter >= MaxOffers)
        {
            Player.SetActive(true);
            Destroy(this.gameObject);
        }

        switch (clickCounter)
        {
            case 1:
                if(currentLanguage == Language.Russian) { text.text = RU1; }
                if(currentLanguage == Language.English) { text.text = EN1; }
                if(currentLanguage == Language.Turkish) { text.text = TU1; }
                break;
            case 2:
                if (currentLanguage == Language.Russian) { text.text = RU2; }
                if (currentLanguage == Language.English) { text.text = EN2; }
                if (currentLanguage == Language.Turkish) { text.text = TU2; }
                break;
            case 3:
                if (currentLanguage == Language.Russian) { text.text = RU3; }
                if (currentLanguage == Language.English) { text.text = EN3; }
                if (currentLanguage == Language.Turkish) { text.text = TU3; }
                break;
            case 4:
                if (currentLanguage == Language.Russian) { text.text = RU4; }
                if (currentLanguage == Language.English) { text.text = EN4; }
                if (currentLanguage == Language.Turkish) { text.text = TU4; }
                break;
            case 5:
                if (currentLanguage == Language.Russian) { text.text = RU5; }
                if (currentLanguage == Language.English) { text.text = EN5; }
                if (currentLanguage == Language.Turkish) { text.text = TU5; }
                break;
            case 6:
                if (currentLanguage == Language.Russian) { text.text = RU6; }
                if (currentLanguage == Language.English) { text.text = EN6; }
                if (currentLanguage == Language.Turkish) { text.text = TU6; }
                break;
        }
    }
}
