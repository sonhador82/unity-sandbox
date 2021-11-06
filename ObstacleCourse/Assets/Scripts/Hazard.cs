using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision projectile");
        if (other.gameObject.layer == 8)
        {
                Player player = other.GetComponent<Player>();
        
                if (player != null)
                player.Die();
        }
    }
}
