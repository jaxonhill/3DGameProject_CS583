using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDmg : MonoBehaviour
{
    public int damage = 1;
    public PlayerInfo playerInfo = null;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Hit Player");
            StaticStats.Health--;
            playerInfo.UpdateHearts();
        }
    }
}
