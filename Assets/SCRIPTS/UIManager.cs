using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public GameObject winPanel;
    public GameObject gameOverPanel;

    void Start()
    {
        // Asegurarse de que los paneles estén desactivados al inicio
        if (winPanel != null)
        {
            winPanel.SetActive(false);
        }

        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(false);
        }
    }

    public void UpdateScore(int score)
    {
        scoreText.text = "Score: " + score;
    }

    public void UpdateTimer(float time)
    {
        timerText.text = time.ToString("00:00");
    }

    public void MostrarPantallaWin()
    {
        winPanel.SetActive(true);
    }

    public void MostrarPantallaGameOver()
    {
        gameOverPanel.SetActive(true);
    }
}