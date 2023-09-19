using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSHot : MonoBehaviour
{
    public GameObject Gun;
    public GameObject MFlash;
    public AudioSource Fire;
    public bool IsFire = false;
    public float TargetD;
    public int DamageAmount = 5;
 
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && GlobalAmmo.AmmoCount >= 1)
        {
            if (IsFire == false)
            {
                GlobalAmmo.AmmoCount -= 1;
                StartCoroutine(FireP());
            }
        }
    }

    IEnumerator FireP()
    {
        RaycastHit Shot;
        IsFire = true;
        if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out Shot))
        {
            TargetD = Shot.distance;
            Shot.transform.SendMessage("DamageZombie", DamageAmount, SendMessageOptions.DontRequireReceiver);
        }
        Gun.GetComponent<Animation>().Play("Pshoot");
        MFlash.SetActive(true);
        MFlash.GetComponent<Animation>().Play("Mussel");
        Fire.Play();
        yield return new WaitForSeconds(0.5f);
        IsFire = false;
    }
}
