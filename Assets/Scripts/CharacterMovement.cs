using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {
    public float speed = 6.0f;
    
    void Start() {
        
    }

    
    void Update() {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaTimeX = deltaX * Time.deltaTime;
        if (transform.position.x + deltaTimeX < 4.5 && transform.position.x + deltaTimeX > -4.5) {
            transform.Translate(deltaTimeX, 0, 0);
        }
    }
}
