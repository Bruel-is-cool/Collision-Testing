using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Wallbreak : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float health = 4f;
    }

    // Update is called once per frame
    
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if(collision.gameObject.tag == "WallBreak")
            {
                health;
            }



        }
    }

