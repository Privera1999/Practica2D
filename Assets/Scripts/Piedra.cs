using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Piedra : MonoBehaviour
{
    public Puntuacion puntuacion;
    public int fruitsCollected;  // Variable para almacenar las frutas recolectadas
    public TMP_Text fruitsText;  // Texto para mostrar la cantidad de frutas

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            // Si colisiona con una fruta, aumentar la variable y actualizar el texto
            puntuacion.piedrastotales+=1;
            UpdateFruitsText();

            // Puedes desactivar o destruir la fruta después de recogerla
            // other.gameObject.SetActive(false);
            // o
            Destroy(gameObject);
        }


    }

    void UpdateFruitsText()
    {
        // Actualizar el texto con la cantidad de frutas recolectadas
        if (fruitsText != null)
        {
            fruitsText.text = "" + puntuacion.piedrastotales;
        }
    }
}
