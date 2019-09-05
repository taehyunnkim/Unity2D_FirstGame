using UnityEngine;

public class HitRadius : MonoBehaviour {
    Animator animator;
    public GameObject blood;
    public bool inRadius;
    public float knockback;

    private void Start() {
        animator = GetComponentInParent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "Player") {
            animator.SetBool("inRadius", true);
            inRadius = true;
            Instantiate(blood, collision.transform.position, collision.transform.rotation);
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.gameObject.name == "Player") {
            animator.SetBool("inRadius", false);
            inRadius = false;

            Instantiate(blood, collision.transform.position, collision.transform.rotation);
            collision.GetComponent<Rigidbody2D>().AddForce(new Vector2(knockback * GetComponentInParent<Knight>().direction, 0));
        }
    }
}
