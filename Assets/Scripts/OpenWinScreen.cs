using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenWinScreen : MonoBehaviour
{
    
    void OnCollisionEnter2D(Collision2D other)
    {	
		if (other.gameObject.CompareTag("Player")) 
 
        {			
			SceneManager.LoadScene("Win Screen");
            Console.WriteLine("It works");
        }
    }
}
