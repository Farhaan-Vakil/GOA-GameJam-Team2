using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthTextScript : MonoBehaviour
{
    public Text HealthText;

    void Update()
    {
        HealthText.text = "Health: " + GameObject.FindWithTag("Enemy").GetComponent<Health>().health;
    }
}
