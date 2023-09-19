using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PULetter : MonoBehaviour
{
    public float DaDistance;
    public GameObject displayAct;
    public GameObject TxtAct;
    public GameObject ExCross;
    public GameObject Letter;

    public GameObject halfFade;
    public GameObject letterImg;
    public GameObject letterTxt;
    void Update()
    {
        DaDistance = PlayerCast.DistanceTarget;
    }

    private void OnMouseOver()
    {
        if (DaDistance <= 3)
        {
            ExCross.SetActive(true);
            TxtAct.GetComponent<Text>().text = "Pick up the letter";
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
                GlobalInventory.Letter01 = true;
                StartCoroutine(LetterPickedUp());
            }
        }
    }
    private void OnMouseExit()
    {
        ExCross.SetActive(false);
        displayAct.SetActive(false);
        TxtAct.SetActive(false);
    }
    IEnumerator LetterPickedUp()
    {
        halfFade.SetActive(true);
        letterImg.SetActive(true);
        letterTxt.SetActive(true);
        yield return new WaitForSeconds(4);
        halfFade.SetActive(false);
        letterImg.SetActive(false);
        letterTxt.SetActive(false);
        Letter.SetActive(false);
    }
   
}
