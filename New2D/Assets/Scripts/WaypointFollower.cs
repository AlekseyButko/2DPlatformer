using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] private GameObject[] waipoints;
    private int currentWaypointIndex = 0;

    [SerializeField] private float speed = 2f;

    
    private void Update()
    {
        if (Vector2.Distance(waipoints[currentWaypointIndex].transform.position, transform.position) < .1f)
        {
            currentWaypointIndex++;
            if(currentWaypointIndex >= waipoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waipoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);
    }
    
}
