using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StalkerAI : MonoBehaviour
{
    public GameObject Dest;
    NavMeshAgent agent;
    public GameObject stalkerEnemy;
    public static bool isStalking;
    public bool AttackTrigger = false;
    public bool isAttacking = false;
    public AudioSource Hurt1;
    public AudioSource Hurt2;
    public AudioSource Hurt3;
    public int HurtsoundGenerator;
    public GameObject Hurtflash;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isStalking == false)
        {
            stalkerEnemy.GetComponent<Animator>().Play("Idle");
        }
        else
        {
            stalkerEnemy.GetComponent<Animator>().Play("Take 001");
            agent.SetDestination(Dest.transform.position);
        }
        if (AttackTrigger == false)
        {
            stalkerEnemy.GetComponent<Animator>().Play("Take 001");
        }
        if (AttackTrigger == true && isAttacking == false)
        {
            stalkerEnemy.GetComponent<Animator>().Play("Attack");
            StartCoroutine(DamagePlayer());
        }
    }
    void OnTriggerEnter()
    {
        AttackTrigger = true;
 
    }
    void OnTriggerExit()
    {
        AttackTrigger = false;
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
