using UnityEngine;

public class bullet : MonoBehaviour {
    public float speed;
    public float knockback;
    public GameObject hit;
    public GameObject blood;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start() {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Boundary") {
            Destroy(gameObject);
        } else if (collision.tag == "Enemy") {
            Destroy(gameObject);
            if (collision.GetComponent<Knight>().health >= 0.5) {
                collision.GetComponent<Knight>().TakeDamage(Weapon.damage);
            }
            Instantiate(hit, transform.position, transform.rotation);
            Instantiate(blood, collision.transform.position, collision.transform.rotation);

            if (transform.rotation.y.ToString().Equals("1")) {
                collision.GetComponent<Rigidbody2D>().AddForce(new Vector2(knockback * -1f, 0));
            } else {
                collision.GetComponent<Rigidbody2D>().AddForce(new Vector2(knockback, 0));
            }
        }
    }

}
