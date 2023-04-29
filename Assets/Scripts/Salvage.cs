using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Salvage : MonoBehaviour
{
    public float timer = 10f;
    bool isClone = false;
    bool isHeld = false;

    

    Vector3 position;
    public Camera cam; 
    
    public void Start()
    {
        if(transform.position.x < 11f)
        {
            isClone = true;
        }
    }

    public void Update()
    {
        position = cam.ScreenToWorldPoint(Input.mousePosition);

        if(Input.GetKeyDown(KeyCode.Mouse0) && onScrap(position))
        {
            isHeld = true;
        }
        
        if(Input.GetKeyUp(KeyCode.Mouse0) && isHeld)
        {
            isHeld = false;
        }

        if(isHeld)
        {
            transform.position = new Vector3(position.x, position.y, 0);
        }

        if(onPouch(transform.position))
        {
            GameObject.Find("ScrapText").GetComponent<ScrapText>().scrap++;
            Destroy(gameObject);
        }
        
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

    bool onScrap(Vector3 pos)
    {
        return pos.x > transform.position.x - 0.25f && pos.x < transform.position.x + 0.25f && pos.y > transform.position.y - 0.25f && pos.y < transform.position.y + 0.25f;
    }

    bool onPouch(Vector3 pos)
    {
        return pos.x > 9.25 && pos.x < 11.25 && pos.y < -4 && pos.y > -6;
    }
}
