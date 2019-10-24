using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField]
    private float speed = 2.5f;

    [SerializeField]
    private float randomOffset = 0.5f;

    private void Update()
    {
        if (!GameManager.Instance.IsGameOver)
        {
            Scrolling();
        }
    }

    private void Scrolling()
    {
        transform.position += Time.deltaTime * speed * Vector3.left;
        if (transform.position.x <= -8)
        {
            if (randomOffset == 0)
            {
                transform.position = new Vector3(7.29f, transform.position.y, transform.position.z);
            }
            else
            {
                float randomHeight = Random.Range(-randomOffset, randomOffset);
                transform.position = new Vector3(7.29f, randomHeight, transform.position.z);
            }

        }
    }
}
