using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField]
    private float jumpForce = 200f;
    
    private Rigidbody2D rigidBody;
    private Animator anim;

    public Score Score;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            rigidBody.velocity = Vector2.zero;
            rigidBody.AddForce(Vector2.up * jumpForce);
            anim.SetTrigger("upflap"); 
        }

        if (transform.position.y > 4.75 || transform.position.y < -4.75)
        {
            GameManager.Instance.GameOver();
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ScoreZone")
        {
            Score.IncreaseScore();
        }
    }

}
