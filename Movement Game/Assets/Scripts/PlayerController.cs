using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal"); // A/D or Left/Right
        float verticalInput = Input.GetAxisRaw("Vertical");   // W/S or Up/Down

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput).normalized * moveSpeed;

        rb.linearVelocity = new Vector3(movement.x, rb.linearVelocity.y, movement.z); //Keep existing Y velocity.
    }
}