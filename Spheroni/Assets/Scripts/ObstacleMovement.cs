using UnityEngine;

public class ObstacleMovement : MonoBehaviour {

    public Transform Obstacle;
    public Vector3 offset;

    
    void Update()
    {
        offset.z = transform.position.z - Obstacle.position.z;
        transform.position = Obstacle.position + offset;
       
    }
}
