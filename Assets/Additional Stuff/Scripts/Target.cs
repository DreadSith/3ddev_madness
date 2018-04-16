using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Target : MonoBehaviour {

    public float health = 30f;

    public AnimationClip Anim;
    private Animation myAnimation;
    


    public void TakeDamage (float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            NavMeshAgent agent = GetComponent<NavMeshAgent>();
            agent.isStopped = true;
            GetComponent<Enemy>().enabled = false;
            myAnimation = GetComponent<Animation>();
            myAnimation.Play(Anim.name);
            Invoke("Die", Anim.length);
        }

    }


    void Die()
    {
        Destroy(gameObject);
    }
}
