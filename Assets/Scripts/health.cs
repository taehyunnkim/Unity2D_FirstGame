using UnityEngine;

public class health : MonoBehaviour {
    float decreaseHealth;
    float enemyHealth;

    private void Start() {
        // divide scale by the damage amount
        decreaseHealth = transform.localScale.x / Weapon.damage;
        GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;
        enemyHealth = (int)FindObjectOfType<Knight>().health;
    }

    public void DecreaseHealth() {
        transform.localScale -= new Vector3(decreaseHealth, 0, 0);
        if ((int)FindObjectOfType<Knight>().health == (int)enemyHealth - (int)Weapon.damage) {
            DisplayHealthBar();
        }
    }

    private void DisplayHealthBar() {
        GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;
    }
}
