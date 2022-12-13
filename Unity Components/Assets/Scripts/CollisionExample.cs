using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ObjectState
{
    OnFloor,
    InAir
}

public class CollisionExample : MonoBehaviour
{
    public ObjectState myState;

    private void Start()
    {
        // GameObject[] objects = GameObject.FindGameObjectsWithTag("Enemy");
        // for (int i = 0; i < objects.Length; i++)
        // {
        //     Debug.Log(objects[i].name);
        // }
    }

    private void Update()
    {
        if (myState == ObjectState.InAir)
        {
            Debug.Log("Uçuyorum");
        }
        else
        {
            Debug.Log("Yerdeyim");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            myState = ObjectState.OnFloor;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            myState = ObjectState.InAir;
        }
    }
}