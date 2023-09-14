using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCast : MonoBehaviour
{
    public static float DistanceTarget;
    public float toTarget;
 
    void Update()
    {
        RaycastHit Hit;
        if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out Hit))
        {
            toTarget = Hit.distance;
            DistanceTarget = toTarget;
        }
    }
}
