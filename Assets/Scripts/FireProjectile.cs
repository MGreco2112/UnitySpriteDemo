using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour {
    [SerializeField] public GameObject projectile;
    private GameObject _projectile;
    
    void Start() {
        
    }

    
    void Update() {
        if (Input.GetKeyDown("space")) {
            _projectile = Instantiate(projectile) as GameObject;
            _projectile.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
        }
        
    }
}
