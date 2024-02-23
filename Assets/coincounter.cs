using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coincounter : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text cointext;   
    public static coincounter instance;
    public int currentCoins = 0;

void Awake()
{
    instance = this;
}   
void Start()
{
        cointext.text = "Coins: " + currentCoins.ToString();
}

    // Update is called once per frame
public void increaseCoins()
{
    currentCoins++;
    cointext.text = "Coins: " + currentCoins.ToString();
}
}
