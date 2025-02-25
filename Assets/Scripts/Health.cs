using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth;
    int currentHealth;

    AudioSource audioSource;
    public AudioClip DieSound;

    private void Start()
    {
        Debug.Log("<color=green><b>The</b> quick <b>brown</b> fox <b>jumps</b> over <b>the</b> lazy <b>dog.</b></color>");
        Debug.Log(Time.time);
        Debug.Log("My Name is "+ gameObject.name);
        currentHealth = maxHealth;
    }

    
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Ow!");
        if (currentHealth <= 0)
        {
            Die();
        }
        if (currentHealth <= 5)
        {
            Debug.Log("I'm Scared!");
        }
    }

    public void Die()
    {
         AudioSource.PlayClipAtPoint(DieSound, gameObject.transform.position);
        Destroy(gameObject);
        Debug.Log("Goodbye!");
        
    }

    




}
