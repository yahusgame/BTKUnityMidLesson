using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;

    private InputAction moveAction;
    public float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        moveAction = new InputSystem_Actions().Player.Move;
        moveAction.Enable();
    }

    void Update()
    {
        Vector2 moveVector = moveAction.ReadValue<Vector2>();
        rb.linearVelocity = moveVector * speed;
    }
}
