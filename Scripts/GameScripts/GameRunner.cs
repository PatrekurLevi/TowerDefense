using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRunner : MonoBehaviour
{

    private bool gameEnded = false;

    void Update()
    {
        if (gameEnded)
        {
            return;
        }
        if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        gameEnded = true;
        Debug.Log("Game Over!");
        SceneManager.LoadScene("GameOver");

    }
}
