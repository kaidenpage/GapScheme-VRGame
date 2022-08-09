using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class WaypointMover : MonoBehaviour
{

    

    //Stores a reference tot he waypoint system this object will use
    [SerializeField] private Waypoints waypoints;

    [SerializeField] private float moveSpeed = 5f;

    [SerializeField] private float distanceThreshold = 0.2f;
  

    //Current waypoint target that the object is moving towards

    private Transform currentWaypoint;
    private Transform initialPosition;
    bool isDoingSomething = true;
    float timer = 0f;
    public AudioSource Hike;

    // Start is called before the first frame update
    void Start()
    {
        //Set initial position to the first waypoint
        



        currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        initialPosition = waypoints.GetNextWaypoint(currentWaypoint);
        transform.position = currentWaypoint.position;
        //Set the next waypoint target
        currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        //transform.LookAt(currentWaypoint);
        

    }

    IEnumerator WaitForSec()
    {
        
        yield return new WaitForSeconds(20f);

        isDoingSomething = true;
        timer = - 1000000000f;
          Hike.Play();
    }

    
        
    // Update is called once per frame
    void Update()
    {

        if (isDoingSomething)
        {
            timer += 0.5f * Time.deltaTime;

            if (timer > 0)
            {
                isDoingSomething = false;
                StartCoroutine(WaitForSec());

            }

             
            transform.position = Vector3.MoveTowards(transform.position, currentWaypoint.position, moveSpeed * Time.deltaTime);
            if (Vector3.Distance(transform.position, currentWaypoint.position) < distanceThreshold)
            {
                currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
                transform.LookAt(currentWaypoint);
         
            }
   
        }
        
    }
}

