using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Player data")]
    //Player data (total coins, per click, per second)

    [Header("Prices")]
    //Total coin prices
    public float coinsPerClickPrice;
    public float coinsPerSecondPrice;

    [Header("Price multipliers")]
    //Price multipliers (e.g. x1.2 etc..)
    public float multiplierCoinsPerClickPrice;
    public float multiplierCoinsPerSecondPrice;

    [Header("Coin Multiplier values")]
    //Total multiplier values
    public float multiplierCoinsPerClick;
    public float multiplierCoinsPerSecond;

    [Header("Base coin multiplier values")]
    //Not needed
    // Here we can set the multiplier of the multiplier
    public float baseMultiplierCoinsPerClick;
    public float baseMultiplierCoinsPerSecond;

    [Header("Text objects")]
    //UI stuff
    public Text playerCoinsText;
    public Text coinsPerClickText;
    public Text coinsPerSecondText;
    public Text pricePerClickText;
    public Text pricePerSecondText;
    public Text multiplierCoinsPerClickText;
    public Text multiplierCoinsPerSecondText;


    [Header("Timer")]
    //Total timer and the click interval
    private float timer = 0;
    private float timerInterval = 1;

    [Header("Colors")]
    //Colors to show depending on current coin state
    public Color32 greenColor;
    public Color32 redColor;
    void Start()
    {
        UpdateUI();
    }
    void Update()
    {
        //Timer
        //Add coins on timer
        //Add coins on click
    }

    private void UpdateUI()
    {
        //Set UI texts according to the data
        //Call the color change
        SetButtonTextColors();
    }
    private void SetButtonTextColors()
    {
        //Set the coin price color according to the difference between player's coins and the price
    }
    public void UpgradeCoinsPerClick()
    {
        //Check if the player has enough coins - if not, print a messange into the console
        //Add coins per click
        //Subtract coins from the player according to the price
        //Upgrade price
        //Upgrade UI
    }
    public void UpgradeCoinsPerSecond()
    {
        //Check if the player has enough coins - if not, print a messange into the console
        //Add coins per second
        //Subtract coins from the player according to the price
        //Upgrade price
        //Upgrade UI
    }
    private bool CanClick()
    {
        //check mouse over UI
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return true;
        }
        //check touch over UI
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            if (EventSystem.current.IsPointerOverGameObject(Input.touches[0].fingerId))
            {
                return true;
            }
        }
        return false;
    }
}
