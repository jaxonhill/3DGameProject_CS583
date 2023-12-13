using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public WeaponController wc;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy" && wc.IsAttacking)
        {
            Debug.Log("Hit Enemy");
            other.gameObject.GetComponent<EnemyAi>().TakeDamage(1);
        }
    }
}
