using UnityEngine;

public class CloudMoveScript : MonoBehaviour
{
    public float moveSpeed = 3f; // Cloud moves 1.5x slower than pipes
    public float deadZone = -30f; // When to destroy the cloud

    void Update()
    {
        transform.position += Vector3.left * (moveSpeed * Time.deltaTime); // Move cloud left

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
