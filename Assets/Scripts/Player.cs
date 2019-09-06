using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    public Animator animator;
    public Transform canvasBoard;

    float xSpeed;
    bool isFiring;

    void Start() {
        speed = 10f;
    }

    private void Update() {
        if (Input.GetKeyDown("space")) {
            isFiring = true;
            animator.SetBool("firing", isFiring);
        } else {
            isFiring = false;
            animator.SetBool("firing", isFiring);
        }
    }

    void FixedUpdate() {
        xSpeed = Input.GetAxis("Horizontal") * speed;
        if (xSpeed > 0) {
            transform.eulerAngles = new Vector3(0, 0, 0);
            canvasBoard.eulerAngles = new Vector3(0, 0, 0);
        } else if (xSpeed < 0) {
            transform.eulerAngles = new Vector3(0, 180, 0);
            canvasBoard.eulerAngles = new Vector3(0, 0, 0);
        }

        Vector3 movement = new Vector3(xSpeed, 0, 0);
        animator.SetFloat("speed", Mathf.Abs(xSpeed));
        transform.position += movement * Time.deltaTime;
    }

}
