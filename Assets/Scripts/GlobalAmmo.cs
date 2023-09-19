using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalAmmo : MonoBehaviour
{
    public static int AmmoCount;
    public GameObject AmmoDisplay;
    public int internalAmmo;
    void Update()
    {
        internalAmmo = AmmoCount;
        AmmoDisplay.GetComponent<Text>().text = "" + AmmoCount; 
    }
}
