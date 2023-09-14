using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameAnims : MonoBehaviour
{
    public int LightMde;
    public GameObject FlameL;
    void Update()
    {
        if (LightMde == 0)
        {
            StartCoroutine(AnimLight());
        }
       
    }

   IEnumerator AnimLight()
    {
        LightMde = UnityEngine.Random.Range(1, 4);
        if (LightMde == 1)
        {
            FlameL.GetComponent<Animation>().Play("TorchAnim01");
        } 
        if (LightMde == 1)
        {
            FlameL.GetComponent<Animation>().Play("TorchAnim02");
        } 
        if (LightMde == 1)
        {
            FlameL.GetComponent<Animation>().Play("TorchAnim03");
        }
        yield return new WaitForSeconds(0.99f);
        LightMde = 0;
    }
}
