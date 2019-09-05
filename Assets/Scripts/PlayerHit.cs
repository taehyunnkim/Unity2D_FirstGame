using UnityEngine;

public class PlayerHit : MonoBehaviour {
    public GameObject blood;

    private void OnCollisionEnter2D(Collider2D collision) {
        if (collision.name == "HitRadius") {
            Instantiate(blood, collision.transform.position, collision.transform.rotation);
        }
    }
}
