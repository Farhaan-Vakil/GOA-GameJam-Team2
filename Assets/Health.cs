using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;
    public int maxHealth = 10;
    public EnemyScript enemyScript;
    public int dropScrap = 0;

    int scraps = 0;

    public GameObject scrap;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        enemyScript = GameObject.Find("Tower").GetComponent<EnemyScript>();
    }

    public void Damage(int damage)
    {
        health -= damage;

        dropScrap = Random.Range(1, 4);
        if(dropScrap == 1)
        {
            Object.Instantiate(scrap, transform.position, transform.rotation);
            scraps ++;
            Debug.Log(scraps);
        }

        if(health <=0)
        {
            enemyScript.createEnemy();
            GameObject.Find("CoinsText").GetComponent<CoinsText>().coins++;
            Destroy(gameObject);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
