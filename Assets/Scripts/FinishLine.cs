using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    public float DaDistance;
    public GameObject displayAct;
    public GameObject TxtAct;
    public GameObject ExCross;
    public AudioSource Locked;
    public AudioSource unlocked;
    public GameObject Doorkey;
    public GameObject WinScreen;
    void Update()
    {
        DaDistance = PlayerCast.DistanceTarget;
    }

    private void OnMouseOver()
    {
        if (DaDistance <= 3)
        {
            ExCross.SetActive(true);
            TxtAct.GetComponent<Text>().text = "Open Door";
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
                ExCross.SetActive(false);
                StartCoroutine(DoorReset());
            }
        }
    }
    private void OnMouseExit()
    {
        ExCross.SetActive(false);
        displayAct.SetActive(false);
        TxtAct.SetActive(false);
    }
    IEnumerator DoorReset()
    {
        if (GlobalInventory.DoorKey == false)
        {
            Locked.Play();
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
        else
        {
            unlocked.Play();
            Doorkey.GetComponent<Animator>().Play("DoorOpenForLocked");
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = false;
            WinScreen.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            SceneManager.LoadScene("GameOver");


        }

    }
}


