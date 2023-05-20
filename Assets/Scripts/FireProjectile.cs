using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour {
    [SerializeField] public GameObject projectile;
    
    void Start() {
        
    }

    
    void Update() {
        if (Input.GetKeyDown("Space")) {
            //instantiate projectile from character
            //have it move positively along the Y axis
        }
        
    }
}
