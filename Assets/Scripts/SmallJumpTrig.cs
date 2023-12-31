using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallJumpTrig : MonoBehaviour
{
    public GameObject cupObj;
    public GameObject sphereTrig;

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        sphereTrig.SetActive(true);
        StartCoroutine(DeactiveSphere());
    }

    IEnumerator DeactiveSphere()
    {
        yield return new WaitForSeconds(0.5f);
        sphereTrig.SetActive(false);
    }
}
