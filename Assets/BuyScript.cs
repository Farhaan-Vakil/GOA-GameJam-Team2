using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyScript : MonoBehaviour
{
    public int coins;
    public GameObject activateObject;
    public Button button;
    bool isBought;

    // Start is called before the first frame update
    void Start()
    {
        button.interactable = false;
        isBought = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!isBought && GameObject.Find("CoinsText").GetComponent<CoinsText>().coins >= coins)
        {
            button.interactable = true;
        }
        else
        {
            button.interactable = false;
        }
    }
    public void clicked()
    {
        if(GameObject.Find("CoinsText").GetComponent<CoinsText>().coins >= coins)
        {
            GameObject.Find("CoinsText").GetComponent<CoinsText>().coins = GameObject.Find("CoinsText").GetComponent<CoinsText>().coins - coins;
            button.interactable = false;
            isBought = true;
        }
    }
}
