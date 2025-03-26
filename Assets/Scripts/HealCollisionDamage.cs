using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealCollisionDamage : MonoBehaviour
{
    public float Heal;
    
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerHealth>()?.HealDamage(Heal);
            Destroy(gameObject);
        }
    }
}
