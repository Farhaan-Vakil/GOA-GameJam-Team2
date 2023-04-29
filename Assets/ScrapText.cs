using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrapText : MonoBehaviour
{
    public int scrap = 0;
    public Text scrapText;

    void Update()
    {
        scrapText.text = "Scrap: " + scrap;
    }

}
