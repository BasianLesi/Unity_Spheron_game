using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement movement;     // A reference to our PlayerMovement script

	// This function runs when we hit another object.
	// We get information about the collision and call it "collisionInfo".
	void OnCollisionEnter (Collision collisionInfo)
	{
		// We check if the object we collided with has a tag called "Obstacle".
		if (collisionInfo.collider.tag == "Obstacle")
		{
            Debug.Log("GAME OVER");
            Invoke("Restart", 1f);
        }
	}
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
   }
