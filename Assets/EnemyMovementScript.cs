using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class EnemyMovementScript : MonoBehaviour
{
    [SerializeField]
    private Transform[] waypoints;
    private GameObject[] temp;

    [SerializeField]
    private float moveSpeed = 2f;

    private int temp2 = 0;

    private int waypointIndex = 0;

    private void Start()
    {
       /* temp  = GameObject.FindGameObjectsWithTag("Waypoint").OrderBy(g => g.transform.GetSiblingIndex()).ToArray();
        for (int i = waypoints.Length - 1; i >= 0; i--)
        {
            waypoints[temp2] = temp[i].transform;
            temp2++;
        }*/
    }

    // Update is called once per frame
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (waypointIndex <= waypoints.Length - 1)
        {

            transform.position = Vector2.MoveTowards(transform.position,
               waypoints[waypointIndex].transform.position,
               moveSpeed * Time.deltaTime);

            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }
        }
    }
}
