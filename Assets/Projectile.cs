using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int damage = 10;
    public Vector2 movementSpeed = new Vector2(3f, 0);
    public Health heal;
    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        heal = GameObject.Find("Enemy(Clone)").GetComponent<Health>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        heal = GameObject.Find("Enemy(Clone)").GetComponent<Health>();
        Vector3 directionToTarget = GameObject.Find("Enemy(Clone)").transform.position - transform.position;
        Vector3 currentDirection = transform.forward;
        float maxTurnSpeed = 60f; 
        Vector3 resultingDirection = Vector3.RotateTowards(currentDirection, directionToTarget, maxTurnSpeed * Mathf.Deg2Rad * Time.deltaTime, 1f);
        //transform.rotation = Quaternion.LookRotation(resultingDirection);
        rb.velocity = resultingDirection * 200;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            heal.Damage(5);
            Destroy(gameObject);
        }
    }
}
