using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableObject : MonoBehaviour
{
    public GameObject fakeObject;
    public GameObject realObject;
    public GameObject sphereObject;

    void DamageZombie(int DamageAmount)
    {
        StartCoroutine(BreakObject());
    }
    IEnumerator BreakObject()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        fakeObject.SetActive(false);
        realObject.SetActive(true);
        yield return new WaitForSeconds(0.05f);
    }
}
