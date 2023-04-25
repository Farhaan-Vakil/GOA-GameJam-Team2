using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyScript : MonoBehaviour
{
    public int coins;
    public GameObject Button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void clicked()
    {
        if (GameObject.Find("CoinsText").GetComponent<CoinsText>().coins >= coins)
        {
            Button.SetActive(true);
            GameObject.Find("CoinsText").GetComponent<CoinsText>().coins = GameObject.Find("CoinsText").GetComponent<CoinsText>().coins - coins;
        }
    }
}
