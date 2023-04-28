using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectile;

    private bool canFire = true;

    // Start is called before the first frame update
    void Start()
    {
       // InvokeRepeating("createProjectile", 0, 3);
    }

    public void createProjectile()
    {
        Object.Instantiate(projectile, transform.position, transform.rotation);
    }

    public void fire()
    {
        canFire = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && canFire == true)
        {
            Invoke("fire", 1f);
            createProjectile();
            canFire = false;
        }

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(mousePos.x + ", " + mousePos.y);
            

    }
}
