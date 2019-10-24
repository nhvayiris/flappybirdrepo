using UnityEngine;

public class Pipe : MonoBehaviour
{
    private void OnCollisionEnter2D (Collision2D collision)
    {

        if (collision.collider.GetComponent<Bird>() != null)
        {
            GameManager.Instance.GameOver();
        }

        
    }

    
}
