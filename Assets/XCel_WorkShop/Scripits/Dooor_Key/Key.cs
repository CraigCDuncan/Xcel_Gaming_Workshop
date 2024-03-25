using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    float DegreesPerSecond = 30;
    private void FixedUpdate()
    {
        transform.Rotate(new Vector3(DegreesPerSecond, DegreesPerSecond, 0) * Time.deltaTime);
    }
}
