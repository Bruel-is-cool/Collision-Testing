
using UnityEngine;

public class TPToSpawn : MonoBehaviour
{
 void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Player"))
        {
            transform.position = new Vector3(0f, 0f, 0f);
        }
    }
}
