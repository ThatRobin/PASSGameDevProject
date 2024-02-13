using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public int health;
    public int maxHealth = 20;

    private void Start()
    {
        health = maxHealth;
    }
    void Update()
    {
        if (health < 0)
        {
            Destroy(this.gameObject);
        }
    }

    public void DamagePlayer(int damage) {
        if (this.health - damage <= 0) {
            this.health = 0;
        } else {
            this.health -= damage;
        }
    }

}
