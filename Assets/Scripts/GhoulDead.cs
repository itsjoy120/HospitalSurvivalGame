using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhoulDead : MonoBehaviour
{
    public int EnemyHealth = 20;
    public GameObject Enemy;
    public int StatusCheck;
    public AudioSource CreepyBackgroundMusicS;

    public void DamageZombie( int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }
    void Update()
    {
        if (EnemyHealth <= 0 && StatusCheck == 0)
        {
            this.GetComponent<GhoulAI>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            StatusCheck = 2;
            Enemy.GetComponent<Animation>().Stop("Idle");
            Enemy.GetComponent<Animation>().Stop("Walk");
            Enemy.GetComponent<Animation>().Play("Death");
        }
    }
}
