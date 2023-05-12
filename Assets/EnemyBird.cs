using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBird : MonoBehaviour
{
    public float damage = .5;
    public float Health
    {
        set
        {
            Health = value;
            if (health <= 0;){
                Dead();
            }
        }
        get
        {
            return health;
        }
    }
    public float health = 1;
    public void onTriggerEnter2D(collider2D other)
    {
        if(other.tag == "Enemy")
        {
            EnemyBird enemy = other.GetComponent<EnemyBird>();
            if(enemy != null)
            {
                enemy.Health -= damage;
            }
        }
        else if(other.tag == "Player")
        {
            Player player = other.GetComponent<player>();
            if(player != null)
            {
                player.Health -= damage;
            }
        }
    }
    public void Dead()
    {
        Destroy(gameObject);
    }
}
