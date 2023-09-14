using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DoorOpen : MonoBehaviour
{
    public float DaDistance;
    public GameObject displayAct;
    public GameObject TxtAct;
    public GameObject DaDoor;
    public AudioSource Sound;
    public GameObject ExCross;
    void Update()
    {
        DaDistance = PlayerCast.DistanceTarget;
    }

    private void OnMouseOver()
    {
        if (DaDistance <= 3)
        {
            ExCross.SetActive(true);
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
                DaDoor.GetComponent<Animation>().Play("Door1Open");
                Sound.Play();
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
