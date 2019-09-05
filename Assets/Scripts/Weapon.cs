using UnityEngine;

public class Weapon : MonoBehaviour {
    public Transform firePoint;
    public GameObject bulletPerfab;
    public static float damage = 10f;

    void Update() {
        if (Input.GetKeyDown("space")) {
            Shoot();
        }
    }

    void Shoot() {
        Instantiate(bulletPerfab, firePoint.position, firePoint.rotation);
    }
}   
