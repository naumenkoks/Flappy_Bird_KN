using UnityEngine;

public class FeatherTailScript : MonoBehaviour
{
    public float flutterInterval = 0.15f; // Faster fluttering
    private bool flipped = false;
    private SpriteRenderer spriteRenderer;
    private Color originalColor;
    private Color darkColor;
    private Vector3 originalScale;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // Get the sprite renderer
        originalColor = spriteRenderer.color; // Store the original color
        darkColor = originalColor * 0.96f; // Slightly darker for subtle effect
        originalScale = transform.localScale; // Store the original scale

        InvokeRepeating("Flutter", 0, flutterInterval);
    }

    void Flutter()
    {
        flipped = !flipped;

        // Flip vertically by inverting the Y scale
        transform.localScale = flipped ? new Vector3(originalScale.x, -originalScale.y, originalScale.z) : originalScale;

        // Switch between original and dark color
        spriteRenderer.color = flipped ? darkColor : originalColor;
    }
}
