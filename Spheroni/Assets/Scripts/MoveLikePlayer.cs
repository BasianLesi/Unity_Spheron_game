using UnityEngine;

public class MoveLikePlayer : MonoBehaviour {

    public Transform Player;
    public Vector3 offset;

    // Update is called once per frame
    void Update ()
    {
        offset.z = transform.position.z - Player.position.z;
        offset.y = transform.position.y - Player.position.y;
        transform.position = Player.position + offset;
    }
}
