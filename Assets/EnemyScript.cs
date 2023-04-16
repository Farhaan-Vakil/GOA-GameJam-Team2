using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        float y = UnityEngine.Random.Range(-5, 5);
        Vector3 temp = new Vector3(4, y, 0);
        Object.Instantiate(enemy, temp, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
