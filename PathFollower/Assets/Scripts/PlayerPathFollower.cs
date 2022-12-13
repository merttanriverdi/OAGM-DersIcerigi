using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPathFollower : MonoBehaviour
{
    [SerializeField] private Transform pathHolder;
    [SerializeField] private float speed = 5f;
    
    private Vector3[] waypoints;
    private int waypointIndex = 0;
    
    private float _maxDistanceToGoal = .1f;

    private bool _canMove;
    
    private void Start()
    {
        waypoints = new Vector3[pathHolder.childCount];
        for (int i = 0; i < waypoints.Length; i++)
        {
            waypoints[i] = pathHolder.GetChild(i).position;
        }
    }
    
    private void Update()
    {
        if(!_canMove) return;
        
        if (waypointIndex >= waypoints.Length)
        {
            _canMove = false;
            Debug.Log("Reached the end of the path");
            return;
        }
        
        transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointIndex], speed * Time.deltaTime);
        if (Vector3.Distance(transform.position,waypoints[waypointIndex])<= _maxDistanceToGoal)
        {
            waypointIndex++;
        }

    }
    
    public void StartMoving()
    {
        _canMove = true;
    }

}
