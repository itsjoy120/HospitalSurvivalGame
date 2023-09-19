using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PUPistol : MonoBehaviour
{
    public float DaDistance;
    public GameObject displayAct;
    public GameObject TxtAct;
    public GameObject FakeGun;
    public GameObject RealGun;
    public GameObject ExCross;
    public GameObject Guide;
    public GameObject JumpTrigger;
    void Update()
    {
        DaDistance = PlayerCast.DistanceTarget;
    }

    private void OnMouseOver()
    {
        if (DaDistance <= 3)
        {
            ExCross.SetActive(true);
            TxtAct.GetComponent<Text>().text = "Pick up pistol";
            displayAct.SetActive(true);
            TxtAct.SetActive(true);

        }
        if (Input.GetButtonDown("Action"))
        {
            if (DaDistance <= 3)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                displayAct.SetActive(false);
                TxtAct.SetActive(false);
                FakeGun.SetActive(false);
                RealGun.SetActive(true);
                Guide.SetActive(false);
                JumpTrigger.SetActive(true);
            }
        }
    }
    private void OnMouseExit()
    {
        ExCross.SetActive(false);
        displayAct.SetActive(false);
        TxtAct.SetActive(false);
    }
}
