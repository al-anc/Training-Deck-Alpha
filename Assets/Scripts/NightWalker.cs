using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class NightWalker : MonoBehaviour
{
    public Transform[] waypoints;
    public NavMeshAgent agent;
    public Transform target;
    public float minDist = 2;
    public int currentWaypoint = 0;
    public bool playerSighted = false;
        // Start is called before the first frame update
    void Start()
    {
        target = waypoints[currentWaypoint];

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float dist = Vector3.Distance(transform.position,target.position);
        
        if(dist < minDist)
        {
            if(playerSighted == true)
            {

            }
            else
            {

            
                currentWaypoint++;
                if(currentWaypoint > 3)
                {
                    
                    currentWaypoint = 0;

                }
                target = waypoints[currentWaypoint];
            }
        }
        else
        {
            agent.SetDestination(target.position);
        }
    }
    void OnTriggerEnter(Collider c)
    {
        if(c.CompareTag("Player"))
        {
            target = c.transform;
            playerSighted = true;
            Debug.Log("Pxxx");
        }

    }
    }
