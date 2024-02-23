using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public float deathHeight = -10f;
    public int maxLives = 3;
    private int currentLives;

    public GameObject[] heartImages; // Arreglo de imágenes de corazones
    public GameObject gameOverPanel;

    // Puedes ajustar esta posición inicial según tu diseño de nivel
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
            // Respawn o cualquier lógica adicional cuando el personaje pierde una vida
            Respawn();
        }
    }

    void Respawn()
    {
        // Resetear la posición del personaje al inicio
        transform.position = initialPosition;
    }

    void UpdateLivesUI()
    {
        // Desactivar las imágenes de corazones que superen el número actual de vidas
        for (int i = 0; i < heartImages.Length; i++)
        {
            heartImages[i].SetActive(i < currentLives);
        }
    }

    void GameOver()
    {
        // Aquí puedes agregar cualquier lógica adicional relacionada con el Game Over
        // Por ejemplo, mostrar un panel de Game Over
        gameOverPanel.SetActive(true);

        // También puedes reiniciar el nivel o cargar un menú principal después de un tiempo
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
