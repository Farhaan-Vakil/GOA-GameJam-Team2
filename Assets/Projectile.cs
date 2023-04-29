using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int damage = 1;
    public Vector2 movementSpeed = new Vector2(10f, 0);
    public Health heal;
    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        heal = GameObject.FindWithTag("Enemy").GetComponent<Health>();
        rb = GetComponent<Rigidbody2D>();
        movementSpeed = new Vector2(50f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        damage = GameObject.Find("Tower").GetComponent<PlayerController>().damage;
        
        heal = GameObject.FindWithTag("Enemy").GetComponent<Health>();
        Vector3 directionToTarget = GameObject.FindWithTag("Enemy").transform.position - transform.position;
        Vector3 currentDirection = transform.forward;
        float maxTurnSpeed = 200f; 
        Vector3 resultingDirection = Vector3.RotateTowards(currentDirection, directionToTarget, maxTurnSpeed * Mathf.Deg2Rad * Time.deltaTime, 1f);
        //transform.rotation = Quaternion.LookRotation(resultingDirection);
        rb.velocity = resultingDirection * 500;

        Debug.Log(damage);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            heal.Damage(damage);
            Destroy(gameObject);
        }
    }

}
