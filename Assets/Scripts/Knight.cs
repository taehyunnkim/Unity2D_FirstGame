using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour {

    public float health;
    public float speed;
    public Animator animator;
    public Rigidbody2D rb;
    public bool isDead;

    public float direction = 1f;
    
    private void Start() {
        if (speed > 0) {
            transform.eulerAngles = new Vector3(0, 0, 0);
        } else if (speed < 0) {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }

    // Update is called once per frame
    void Update() {
        if (health <= 0) {
            animator.SetBool("isDead", true);
            isDead = true;
            Destroy(gameObject, animator.GetCurrentAnimatorStateInfo(0).length);
        }
    }

    private void FixedUpdate() {
        rb.velocity = new Vector2(speed, 0);
        animator.SetFloat("velocity", Mathf.Abs(rb.velocity.x));

        if (isDead) {
            rb.velocity = Vector2.zero;
        } else if (GetComponentInChildren<HitRadius>().inRadius) {
            rb.velocity = Vector2.zero;
        }
    }

    public void TakeDamage(float damage) {
        health -= damage;
        GetComponentInChildren<health>().DecreaseHealth();
        //Debug.Log(health);
    }
}
