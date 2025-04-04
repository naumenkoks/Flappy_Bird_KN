using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;

    public SpriteRenderer spriteRenderer;
    public Sprite birdUpSprite;
    public Sprite birdDownSprite;

    private Vector3 defaultScale; // Store the default scale when game starts
    public AudioSource flapSound;
    public AudioSource PipeHitSound;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        // **Flip the bird to face right**
        spriteRenderer.flipX = true;

        // **Save the current scale as the default**
        defaultScale = transform.localScale;

        // **Set the starting sprite**
        spriteRenderer.sprite = birdUpSprite;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
            spriteRenderer.sprite = birdDownSprite;

            // Ensure scale stays the same when switching sprites
            transform.localScale = defaultScale;
        }

        if (myRigidbody.linearVelocity.y < 0)
        {
            spriteRenderer.sprite = birdUpSprite;

            // Ensure scale stays the same when switching sprites
            transform.localScale = defaultScale;
        }
        /*if (transform.position.y > 15 || transform.position.y < -15)
        {
            logic.gameOver();
            birdIsAlive = false;
        }*/
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
            spriteRenderer.sprite = birdDownSprite;
            transform.localScale = defaultScale;

            flapSound.Play();
        }
       


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
        PipeHitSound.Play();
    }
    
}
