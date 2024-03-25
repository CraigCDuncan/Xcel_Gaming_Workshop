using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveing_Object : MonoBehaviour
{
    public GameObject PointA;
    public GameObject PointB;
    public Transform CurrentTarget;
    public float Speed;

    // Update is called once per frame
    private void Awake()
    {
        
        CurrentTarget = PointA.transform;
    }

    void FixedUpdate ()
    {
        float step= Speed* Time.deltaTime;
        gameObject.transform.position = Vector3.MoveTowards(transform.position, CurrentTarget.position, step);

        if (Vector3.Distance(transform.position, PointA.transform.position) < 0.0001f)
        {
            CurrentTarget = PointB.transform;
        }
        else if (Vector3.Distance(transform.position, PointB.transform.position) < 0.0001f) 
        { 
            CurrentTarget=PointA.transform;
        } 
    }
    private void OnTriggerEnter(Collider other)
    {
        other.transform.SetParent(transform);
    }
    private void OnTriggerExit(Collider other)
    {
        other.transform.SetParent(null);
    }
}
