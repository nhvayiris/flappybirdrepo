using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    public bool isGameOver { get; private set; }
    public float restartDelay = 2f;

    public GameObject gameOver;
    
    

    public void Awake()
    {

        if (Instance != null)
        {
            Debug.LogWarning("Two Game Managers in the scene!");

        }
        else
        {
            Instance = this;
        }

    }

    public void GameOver()
    {

        if (!isGameOver)
        {
            isGameOver = true;
            gameOver.SetActive(true);

            Debug.Log("Game Over :c");
            
            Invoke("Restart", restartDelay);
            
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
