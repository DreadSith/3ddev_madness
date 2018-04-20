using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour
{

    public int Dmg;

    void OnCollisionEnter(Collision collision)
    {
        var hit = collision.gameObject;
        var health = hit.GetComponent<Health>();
        if (health != null)
        {
            health.TakeDamage(Dmg);
        }
    }

}