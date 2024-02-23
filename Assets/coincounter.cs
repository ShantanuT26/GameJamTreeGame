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
    public Camera mainCamera;

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
void LateUpdate()
{
    float screenWidth = Screen.width;
    float screenHeight = Screen.height;
    Vector3 cameraPosition = mainCamera.transform.position;
    RectTransform rectTransform = cointext.rectTransform;
    rectTransform.anchoredPosition = new Vector2(0f, screenHeight);
    Vector3 screenPosition = mainCamera.WorldToScreenPoint(cameraPosition);
    rectTransform.anchoredPosition = new Vector2(screenPosition.x / screenWidth, 1f - (screenPosition.y / screenHeight));
}
}
