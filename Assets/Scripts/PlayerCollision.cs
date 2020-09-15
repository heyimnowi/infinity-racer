using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    // Start is called before the first frame update

    public PlayerMovement movement;
    public GameManager gameManager;
    void OnCollisionEnter(Collision collisionInfo) {

        if (collisionInfo.collider.tag == "Obstacle") {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    // Update is called once per frame
    void Update() {
    }
}
