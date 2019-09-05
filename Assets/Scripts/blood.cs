using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blood : MonoBehaviour {
    public ParticleSystem ps;

    // Update is called once per frame
    void Update() {
        if (!ps.IsAlive()) {
            Destroy(gameObject);
        }
    }
}
