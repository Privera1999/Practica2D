using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public float deathHeight = -10f;
    public int maxLives = 3;
    private int currentLives;

    public TMP_Text livesText;
    public GameObject gameOverPanel;

    // Puedes ajustar esta posici�n inicial seg�n tu dise�o de nivel
    public Vector3 initialPosition = new Vector3(0f, 0f, 0f);

    private void Start()
    {
        currentLives = maxLives;
        UpdateLivesUI();
        gameOverPanel.SetActive(false);
    }

    private void Update()
    {
        if (transform.position.y < deathHeight)
        {
            LoseLife();
        }
    }

    public void LoseLife()
    {
        currentLives--;

        // Actualizar el contador visual de vidas
        UpdateLivesUI();

        Debug.Log("Altura actual: " + transform.position.y);

        if (currentLives <= 0)
        {
            GameOver();
        }
        else
        {
            // Respawn o cualquier l�gica adicional cuando el personaje pierde una vida
            Respawn();
        }
    }

    void Respawn()
    {
        // Resetear la posici�n del personaje al inicio
        transform.position = initialPosition;
    }

    void UpdateLivesUI()
    {
        if (livesText != null)
        {
            livesText.text = "Vidas: " + currentLives;
        }
    }

    void GameOver()
    {
        // Aqu� puedes agregar cualquier l�gica adicional relacionada con el Game Over
        // Por ejemplo, mostrar un panel de Game Over
        gameOverPanel.SetActive(true);

        // Tambi�n puedes reiniciar el nivel o cargar un men� principal despu�s de un tiempo
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
