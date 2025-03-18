using UnityEngine;
using Unity.UI;
using Microsoft.Unity.VisualStudio.Editor;

[RequireComponent(typeof(Rigidbody2D))]         //Tell Unity to add theses components to the gameobject this code is attached to.
[RequireComponent(typeof(BoxCollider2D))]       //We will still need to tweak some of the settings.
public class RigidbodyMovement : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb2d;
    public float moveSpeed = 5f;

    public Image StaminaBar;

    public float Stamina, MaxStamina;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        

        float moveInputX = Input.GetAxisRaw("Horizontal"); // For horizontal movement (left/right)
        float moveInputY = Input.GetAxisRaw("Vertical");   // For vertical movement (up/down)

        animator.SetFloat("InputX", moveInputX);
        animator.SetFloat("InputY", moveInputY);

        // Normalise the vector so that we don't move faster when moving diagonally.
        Vector2 moveDirection = new Vector2(moveInputX, moveInputY);
        moveDirection.Normalize();

        // Assign velocity directly to the Rigidbody
        rb2d.velocity = moveDirection * moveSpeed;

        if (Input.GetButton("Fire3"))
        {
            moveSpeed = 5.5f;
        }

        if (Input.GetButtonUp("Fire3"))
        {
            moveSpeed = 3f;
        }
    }

    
}