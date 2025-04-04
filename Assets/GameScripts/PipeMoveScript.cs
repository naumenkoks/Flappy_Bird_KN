using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 2;
    public float deadZone = -45;

    private Transform topPipe;
    private Transform bottomPipe;
    private Collider2D topCollider;
    private Collider2D bottomCollider;

    public float verticalLimit = 24f; // Y threshold for disabling collider

    void Start()
    {
        topPipe = transform.Find("Top Pipe");
        bottomPipe = transform.Find("Bottom Pipe");

        if (topPipe != null)
            topCollider = topPipe.GetComponent<Collider2D>();

        if (bottomPipe != null)
            bottomCollider = bottomPipe.GetComponent<Collider2D>();
    }

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        // Handle Top Pipe
        if (topPipe != null && topCollider != null)
        {
            if (Mathf.Abs(topPipe.position.y) > verticalLimit)
            {
                if (topCollider.enabled)
                {
                    topCollider.enabled = false;
                    Debug.Log("Top pipe collider DISABLED (off-screen Y = " + topPipe.position.y + ")");
                }
            }
            else
            {
                if (!topCollider.enabled)
                {
                    topCollider.enabled = true;
                    Debug.Log("Top pipe collider RE-ENABLED (on-screen Y = " + topPipe.position.y + ")");
                }
            }
        }

        // Handle Bottom Pipe
        if (bottomPipe != null && bottomCollider != null)
        {
            if (Mathf.Abs(bottomPipe.position.y) > verticalLimit)
            {
                if (bottomCollider.enabled)
                {
                    bottomCollider.enabled = false;
                    Debug.Log("Bottom pipe collider DISABLED (off-screen Y = " + bottomPipe.position.y + ")");
                }
            }
            else
            {
                if (!bottomCollider.enabled)
                {
                    bottomCollider.enabled = true;
                    Debug.Log("Bottom pipe collider RE-ENABLED (on-screen Y = " + bottomPipe.position.y + ")");
                }
            }
        }

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
