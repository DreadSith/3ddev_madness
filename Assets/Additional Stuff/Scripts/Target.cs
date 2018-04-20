using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Target : MonoBehaviour {

    public float health = 30f;

    public AnimationClip Anim;
    private Animation myAnimation;

    public GameObject objectToAccess;
    

    public void TakeDamage (float amount)
    {
        health -= amount;

        if (health == 0f)
        {
            Score.score += 1;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
            NavMeshAgent agent = GetComponent<NavMeshAgent>();
            agent.isStopped = true;
            GetComponent<Enemy>().enabled = false;
            myAnimation = GetComponent<Animation>();
            myAnimation.Play(Anim.name);
            Invoke("RespawnEnemy", Anim.length);
            Invoke("Die", Anim.length);

        }

    }

    void Die()
    {
        Destroy(gameObject);
    }

    void RespawnEnemy()
    {
        Respawn scriptToAccess = objectToAccess.GetComponent<Respawn>();
        scriptToAccess.SpawnObject();
    }
  
}
