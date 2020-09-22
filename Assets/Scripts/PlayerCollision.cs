using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    // Start is called before the first frame update

    public PlayerMovement movement;
    public GameManager gameManager;
    void OnCollisionEnter(Collision collisionInfo) {
            Debug.Log("Hit something: " + collisionInfo.collider.name);
        if (collisionInfo.collider.tag == "Obstacle") {
            Debug.Log("Hit obstacle");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
