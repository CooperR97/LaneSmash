﻿using UnityEngine;

public class Target : MonoBehaviour
{

    public float health = 10f;

    public void TakeDamage(float amount)
    {
        health -= amount;

        if(health <= 0)
        {
            Die();
        }

        void Die()
        {
            Destroy(gameObject);
        }

    }

}
