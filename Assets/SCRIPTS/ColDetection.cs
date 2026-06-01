using UnityEngine;

public class ColDetection : MonoBehaviour
{
    public int score = 0;
    public int maxScore = 10; // Puntaje máximo para ganar
    private UIManager uiManager;

    void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("celu"))
        {
            Destroy(other.gameObject);
            score++;
            uiManager.UpdateScore(score);

            // Verificar si se alcanzó el puntaje máximo
            if (score >= maxScore)
            {
                Win();
            }
        }
    }

    void Win()
    {
        Time.timeScale = 0; // Detener el tiempo
        if (uiManager != null)
        {
            uiManager.MostrarPantallaWin();
        }
    }
}