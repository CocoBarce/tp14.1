using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timer = 60f;
    private UIManager uiManager;
    private bool gameEnded = false;

    void Start()
    {
        Time.timeScale = 1; // Restablecer el tiempo al iniciar
        uiManager = FindObjectOfType<UIManager>();
        if (uiManager != null)
        {
            uiManager.UpdateTimer(timer);
        }
    }

    void Update()
    {
        if (gameEnded)
        {
            // Reiniciar el juego si se presiona "R"
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            return;
        }

        // Restar el tiempo
        timer -= Time.deltaTime;
        if (timer < 0) timer = 0;

        if (uiManager != null)
        {
            uiManager.UpdateTimer(timer);
        }

        // Verificar si el tiempo llegó a 0
        if (timer <= 0 && !gameEnded)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        gameEnded = true;
        Time.timeScale = 0; // Detener el tiempo
        if (uiManager != null)
        {
            uiManager.MostrarPantallaGameOver();
        }
    }
}