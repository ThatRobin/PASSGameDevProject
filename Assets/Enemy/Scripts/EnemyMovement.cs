using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    Rigidbody2D rb;
    GroundCheck gc;

    [SerializeField] float jumpRange = 3.5f;
    [SerializeField] float jumpHeight = 3f;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        gc = GetComponentInChildren<GroundCheck>();
        StartCoroutine("WaitAndJump");
    }

    void Update() {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("Player")) {
            PlayerManager manager = collision.gameObject.GetComponent<PlayerManager>();
            manager.health -= 1;
        }
    }

    IEnumerator WaitAndJump() {
        if (gc.isGrounded) {
            float direction = Random.Range(-1f, 1f);
            rb.AddForce(new Vector2(direction * jumpRange, jumpHeight), ForceMode2D.Impulse);
        }
        yield return new WaitForSeconds(1);
        yield return WaitAndJump();
    }

}
