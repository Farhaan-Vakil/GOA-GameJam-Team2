using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyScript : MonoBehaviour
{
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        createEnemy();
    }

    public void createEnemy()
    {
        Object.Instantiate(enemy, enemy.transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
