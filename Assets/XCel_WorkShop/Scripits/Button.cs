using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject[] Objs;
    bool InTrigger = false;
    int i = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            InTrigger = true;
            Debug.Log("In Trigger");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            InTrigger = false;
            Debug.Log("out Trigger");
        }
    }
    private void Update()
    {
        if(InTrigger==true)
        {
            Debug.Log("press E");
            if (Input.GetKeyDown(KeyCode.E)) {
                i = 0;
                foreach (GameObject obj in Objs)
                {
                    if
                (Objs[i].activeInHierarchy)
                    {
                        Objs[i].SetActive(false);
                        i++;
                    }
                    else
                    {
                        Objs[i].SetActive(true);
                        i++;
                    }
                }
            }
        }
    }
}
