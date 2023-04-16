using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("createProjectile", 0, 3);
    }

    public void createProjectile()
    {
        Object.Instantiate(projectile, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
            
    }
}
