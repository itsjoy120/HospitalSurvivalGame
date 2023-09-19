using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalInventory : MonoBehaviour
{
    public static bool DoorKey = false;
    public bool internalDoorKey;
    public static bool Letter01 = false;
    void Update()
    {
        internalDoorKey = DoorKey; 
    }
}
