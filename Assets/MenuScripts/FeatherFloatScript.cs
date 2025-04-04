using UnityEngine;

public class FeatherFloatScript : MonoBehaviour
{
    public float fallSpeed = 1f;
    public float swaySpeed = 2f;
    public float swayAmount = 0.5f;

    private float startX;
    private float timeOffset;

    void Start()
    {
        startX = transform.position.x;
        timeOffset = Random.Range(0f, 2f * Mathf.PI);
    }

    void Update()
    {
        float sway = Mathf.Sin(Time.time * swaySpeed + timeOffset) * swayAmount;
        transform.position += new Vector3(sway * Time.deltaTime, -fallSpeed * Time.deltaTime, 0);
    }
}
