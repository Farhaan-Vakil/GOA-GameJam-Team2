using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrapBuy : MonoBehaviour
{
    public int scrap;
    public GameObject activateObject;
    public Button button;


    // Start is called before the first frame update
    void Start()
    {
        button.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("ScrapText").GetComponent<ScrapText>().scrap >= scrap)
        {
            button.interactable = true;
        }
        else
        {
            button.interactable = false;
        }
    }

    public void assignObject()
    {
        activateObject = GameObject.Find("Projectile");
    }
    
    public void clicked()
    {
        if(GameObject.Find("ScrapText").GetComponent<ScrapText>().scrap >= scrap)
        {
            GameObject.Find("ScrapText").GetComponent<ScrapText>().scrap = GameObject.Find("ScrapText").GetComponent<ScrapText>().scrap - scrap;
            activateObject.SetActive(true);
            GameObject.Find("Tower").GetComponent<PlayerController>().increaseDamage();
            Debug.Log("clickd");
        }
    }
}
