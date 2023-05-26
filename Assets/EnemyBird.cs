using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBird : MonoBehaviour
{
    private void Update()
    {
        if(target != null)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, target.position, step);
        }
    }
    Collider2D enemyCollider;
    public double damage = 1;
    public double Health
    {
        set
        {
            Health = value;
            if (health <= 0)
            {
                Dead();
            }
        }
        get
        {
            return health;
        }
    }
    public double health = 1;
    private void Start()
    {
        enemyCollider = GetComponent<Collider2D>();
        enemyCollider.enabled = true;
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        //if(other.tag == "Player")
        //{
        //PlayerController player = other.GetComponent<PlayerController>();
        //if(player != null)
        //{
        if (other.gameObject.name == "EnemyBird")
        {
            health -= damage;
        }
    }
    public void Dead()
    {
        Destroy(gameObject);
    }
    public float speed = 3f;
    private Transform target;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            target = other.transform;
        }
    }
}
