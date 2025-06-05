using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float movementSpeed = 5f;
    [SerializeField] private Rigidbody2D rb;
    private Vector2 movementInput;
    public void Move(InputAction.CallbackContext context)
    {
        movementInput=context.ReadValue<Vector2>();
    }
    private void FixedUpdate()
    {
        if (movementInput != null)
        {
            rb.linearVelocity = movementInput*movementSpeed;
        }
    }
}
