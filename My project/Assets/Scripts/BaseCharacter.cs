using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacter : MonoBehaviour, IDamageable
{
    private int health;
    public int Health { get { return health; } }

    public void TakeDamage(int damage) {
        health -= damage;
        if (damage <= 0) {
            Die();
        }
    }
    public void Die() {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
