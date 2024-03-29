using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {

    public bool isGrounded;

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Ground")) {
            isGrounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
