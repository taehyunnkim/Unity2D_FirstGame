using UnityEngine;

public class Weapon : MonoBehaviour {
    public Transform firePoint;
    public GameObject bulletPerfab;
    public static float damage = 10f;
    public float ammo;

    public GameObject reloading;
    public GameObject reload;

    private void Start() {
        
    }

    void Update() {
        if (Input.GetKeyDown("space") && ammo > 0) {
            Shoot();
        } else if (Input.GetKeyDown("r")) {
            reload.SetActive(false);
            reloading.SetActive(true);
            ammo = 0;
            Invoke("Reload", 4);
        } else if (ammo.Equals(0f)) {
            if (!reloading.activeSelf) {
                reload.SetActive(true);
            }
        }
    }

    void Shoot() {
        Instantiate(bulletPerfab, firePoint.position, firePoint.rotation);
        ammo -= 1f;
    }

    void Reload() {
        reloading.SetActive(false);
        ammo = 10f;
    }
}   
