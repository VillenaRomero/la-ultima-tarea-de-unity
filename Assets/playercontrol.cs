using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
    void FixeUpdate() {
        _compRigybody.velocity = new Vector2(horizontal * speedX, vertical * speedY);
    }
    private void OntriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.Tag == "Enemy") {
            Destroy(collision.gameObject);
        }
    }
}
