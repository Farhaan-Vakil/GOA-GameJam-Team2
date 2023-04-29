using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectile;
    public Camera cam; 

    Vector3 position;

    private bool canFire = true;

    public int damage = 1;

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
        if (Input.GetKey(KeyCode.Mouse0) && canFire == true && mouseOnButton())
        {
            Invoke("fire", 1f);
            createProjectile();
            canFire = false;
        }
        
            

    }

    public void increaseDamage()
    {
        damage++;
    }

    bool mouseOnButton()
    {
        position = cam.ScreenToWorldPoint(Input.mousePosition);
        return position.x < -9.25 && position.x > -11.25 && position.y < -4 && position.y > -6;
    }
}
