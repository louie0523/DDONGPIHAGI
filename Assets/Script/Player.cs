using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(h * moveSpeed, rb.linearVelocity.y);
    }
}