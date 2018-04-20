using UnityEngine;

public class SlowDown : MonoBehaviour {

    public PlayerMovement Move;
    public Transform Player;
	// Update is called once per frame
	void Update () {
		  if (Player.position.z>4300 && Player.position.z<4450)
        {
            Move.forwardForce = 2500;
        }
          else { Move.forwardForce = 10000; }
	}
}
