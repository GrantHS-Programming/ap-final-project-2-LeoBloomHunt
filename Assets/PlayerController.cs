using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public GameObject textmeshpro_health;
    public int textmeshpro_h;
    TextMeshProUGUI textmeshpro_health_text;
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
        textmeshpro_health_text = textmeshpro_health.GetComponent<TextMeshProUGUI>();
        playerCollider = GetComponent<Collider2D>();
        playerCollider.enabled = true;
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "EnemyBird")
        {
            
            Health -= damage*20;
        }
    }
    public void OnCollisionStay2D(Collision2D other)
    {
        if(other.gameObject.name == "EnemyBird")
        {
            Health -= damage;
        }
    }
    void Update()
    {
        textmeshpro_health_text.text = (""+(int)(health * 100));
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
        Time.timeScale = 0f;
        Destroy(gameObject);
    }
}
