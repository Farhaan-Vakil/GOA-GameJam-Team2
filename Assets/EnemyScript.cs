using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyScript : MonoBehaviour
{
    public GameObject enemy;
    private Vector3 enemyPos;

    // Start is called before the first frame update
    void Start()
    {
        //createEnemy();
        enemyPos = enemy.transform.position;

    }

    public void createEnemy()
    {
        Object.Instantiate(enemy, enemyPos, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        enemy = GameObject.FindWithTag("Enemy");
    }
}
