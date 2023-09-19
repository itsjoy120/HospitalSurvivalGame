using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger1 : MonoBehaviour
{
    public GameObject Player;
    public GameObject TxtBox;
    public GameObject Marker;

    void OnTriggerEnter()
    {
        this.GetComponent<BoxCollider>().enabled = false;
        Player.GetComponent<CharacterControllerS>().enabled = false;
        StartCoroutine(ScenePlayer());
    }

    IEnumerator ScenePlayer()
    {
        TxtBox.GetComponent<Text>().text = "A weapon! I think I'll need it...";
        yield return new WaitForSeconds(1.5f);
        TxtBox.GetComponent<Text>().text = "";
        Player.GetComponent<CharacterControllerS>().enabled = true;
        Marker.SetActive(true);
    }
}
