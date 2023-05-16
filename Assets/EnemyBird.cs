using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBird : MonoBehaviour
{
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
        if (other.gameObject.name == "Player")
        {
            Dead();
            //other.gameObject.Health -= damage;
            //other.gameObject.Dead();
        }
            //}
        //}
    }
    public void Dead()
    {
        Destroy(gameObject);
    }
}
