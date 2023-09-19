using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUAmmo : MonoBehaviour
{
    public GameObject ammoBox;
    void OnTriggerEnter(Collider other)
    {
        ammoBox.SetActive(true);
        GlobalAmmo.AmmoCount += 10;
        gameObject.SetActive(false);
    }
}
