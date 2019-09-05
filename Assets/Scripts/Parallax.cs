using UnityEngine;

public class Parallax : MonoBehaviour {

    float lenght, startPos;
    public GameObject player;
    public float parallax;

    // Start is called before the first frame update
    void Start() {
        startPos = transform.position.x;
        //length = GetComponent<SpriteRenderer>.bounds.size.x;    
    }

    // Update is called once per frame
    void Update() {
        
    }
}
