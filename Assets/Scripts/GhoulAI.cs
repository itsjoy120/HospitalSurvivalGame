using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhoulAI : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemy;
    public float EnemySpeed = 0.01f;
    public bool AttackTrigger = false;
    public bool isAttacking = false;
    public AudioSource Hurt1;
    public AudioSource Hurt2;
    public AudioSource Hurt3;
    public int HurtsoundGenerator;
    public GameObject Hurtflash;

    void Update()
    {
        // makes enemy look at player
        transform.LookAt(Player.transform);
        if (AttackTrigger == false)
        {
            EnemySpeed = 0.03f;
            Enemy.GetComponent<Animation>().Play("Walk");
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, EnemySpeed);
        }
        if (AttackTrigger == true && isAttacking == false)
        {
            EnemySpeed = 0f;
            Enemy.GetComponent<Animation>().Play("Attack1");
            StartCoroutine(DamagePlayer());
        }
    }
     void OnCollisionStay(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            AttackTrigger = true;
        }
        
    } 
    void OnCollisionExit(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            AttackTrigger = false;
        }
         
    }
    IEnumerator DamagePlayer()
    {
        isAttacking = true;
        HurtsoundGenerator = Random.Range(1, 4);
        if (HurtsoundGenerator == 1)
        {
            Hurt1.Play();
        }
        if (HurtsoundGenerator == 1)
        {
            Hurt2.Play();
        }
        if (HurtsoundGenerator == 1)
        {
            Hurt3.Play();
        }
        Hurtflash.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Hurtflash.SetActive(false);
        yield return new WaitForSeconds(1.2f);
        GlobalHEalth.currentHP -= 5;
        yield return new WaitForSeconds(1.0f);
        isAttacking = false;
    }
}
