using UnityEngine.InputSystem;
using UnityEngine;

[RequireComponent(typeof(PlayerInput))]
public class PlayerController : MonoBehaviour
{
    InputControl controls;

    [SerializeField] float moveSpeed = 1f;
    [SerializeField] BoxCollider2D boxCollider2D;
    Rigidbody2D rgb2D;

    Vector2 movement;

    public int moveDirection;

    private void Start()
    {
        moveSpeed = moveSpeed <= 0 ? 1f : moveSpeed;
    }

    private void Update()
    {
        transform.position += new Vector3(movement.x, 0, 0) * moveSpeed * Time.deltaTime;
    }

    public void OnMove(InputValue inputValue)
    {
        Debug.Log("Move");
        movement = inputValue.Get<Vector2>();
    }
}
