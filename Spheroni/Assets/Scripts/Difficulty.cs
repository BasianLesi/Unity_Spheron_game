using UnityEngine;

public class Difficulty : MonoBehaviour {

    public PlayerMovement playermv;

    public void Εasy()
    {
        playermv.forwardForce = 1000f;
    }

    public void Μedium()
    {
        playermv.forwardForce = 8000f;
    }

    public void Ηard()
    {
        playermv.forwardForce = 10000f;
        playermv.sidewaysForce = 150;
    }
}
