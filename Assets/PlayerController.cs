using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Collider2D playerCollider;
    public double Health
    {
        set
        {
            health = value;
            if (health <= 0){
                Dead();
            }
        }
        get
        {
            return health;
        }
    }
    public double health = 1;
    public double damage = 1f;
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 moveDirection;
    Vector2 mousePositition;
    private void Start()
    {
        playerCollider = GetComponent<Collider2D>();
        playerCollider.enabled = true;
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "EnemyBird")
        {
            
            Health -= damage;
        }
    }
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(moveX, moveY).normalized;
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);

    }
    public void Dead()
    {
        Destroy(gameObject);
    }
}
