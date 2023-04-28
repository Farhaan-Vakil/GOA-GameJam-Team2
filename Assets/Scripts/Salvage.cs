using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Salvage : MonoBehaviour
{
    public float timer = 10f;
    bool isClone = false;
    
    public void Start()
    {
        if(transform.position.x < 11f)
        {
            isClone = true;
        }
    }

    public void Update()
    {
        if(isClone)
        {
            if(timer > 0f)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
