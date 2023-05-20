using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    public float speed = 5f;
    
    void Start() {

    }

    
    void Update() {
        transform.Translate(0, speed * Time.deltaTime, 0);

        if (transform.position.y > 5) {
            Destroy(this.gameObject);
        }
    }
}
