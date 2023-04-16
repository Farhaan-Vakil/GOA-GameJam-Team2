using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthTextScript : MonoBehaviour
{
    public Text HealthText;

    void Update()
    {
        HealthText.text = "Health: " + GameObject.Find("Enemy(Clone)").GetComponent<Health>().health;
    }
}
