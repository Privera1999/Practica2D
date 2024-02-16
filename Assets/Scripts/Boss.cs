using UnityEngine;

public class EnemyController : MonoBehaviour
{
 

    public GameObject player;  // Asegúrate de asignar el jugador en el Inspector

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        
    }

    

private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Llamando a LoseLife() del PlayerDeath adjunto al jugador
            PlayerDeath playerDeath = collision.GetComponent<PlayerDeath>();

            if (playerDeath != null)
            {
                playerDeath.LoseLife();
            }
            else
            {
                Debug.LogError("PlayerDeath no encontrado en el GameObject del jugador.");
            }
        }
    }
}
