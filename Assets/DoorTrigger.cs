
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
   
    public GameObject hiddenDoor;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Player"))
        {
            hiddenDoor.SetActive(false);
        }
    }

     void OnTriggerExit2D(Collider2D collider)
    {
        if(collider.CompareTag("Player"))
        {
            hiddenDoor.SetActive(true);
        }
    }



}
