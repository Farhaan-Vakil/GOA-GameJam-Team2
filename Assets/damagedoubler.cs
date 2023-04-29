using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damagedoubler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Tower").GetComponent<PlayerController>().increaseDamage();
        Debug.Log("inced");
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
