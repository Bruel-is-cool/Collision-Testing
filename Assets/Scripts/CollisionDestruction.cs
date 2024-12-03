
using UnityEngine;

public class CollisionDestruction : MonoBehaviour
{
   void OnCollisionEnter2D(Collision2D collision)
   {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collision detected.");
            Destroy(gameObject);
        }
   }
}
