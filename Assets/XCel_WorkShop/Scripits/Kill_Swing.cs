using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill_Swing : MonoBehaviour
{
    public GameObject Povit;
    public float Speed;
    public Game_Master GM;
    public bool SwingD;
    public GameObject PointA;
    public GameObject PointB;
    public float Offset;




    void FixedUpdate()
    {
        if (SwingD == true)
        {
            transform.RotateAround(Povit.transform.position, Vector3.back, Speed * Time.deltaTime);
        } else if (SwingD == false)
        {
            transform.RotateAround(Povit.transform.position, Vector3.forward, Speed * Time.deltaTime);
        }
        
        if (Vector3.Distance(transform.position, PointA.transform.position) < Offset)
        {
            SwingD = true;
        }
        else if (Vector3.Distance(transform.position, PointB.transform.position) < Offset)
        {
            SwingD =false;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player") 
        {
            GM.Resart();
        }
    }
}
