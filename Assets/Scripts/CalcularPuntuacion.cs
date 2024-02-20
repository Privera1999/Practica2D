using UnityEngine;
using TMPro;

public class GestorPuntuacion : MonoBehaviour
{
    public Puntuacion scriptPuntuacion; // Referencia al script Puntuacion
    public ContadorDeTiempo scriptContadorTiempo; // Referencia al script ContadorDeTiempo
    public TMP_Text uiTextPuntuacionTotal; // Referencia al componente TextMeshPro para mostrar la puntuación total

    void Start()
    {
       
    }

    void Update()
    {
        // Puedes llamar a esta función en respuesta a algún evento del juego, como un botón de finalización de nivel
        // Este es solo un ejemplo, puedes llamar a esta función en cualquier momento que desees calcular y mostrar la puntuación total
        
            
        
    }

   public void CalcularPuntuacionTotal()
    {
        // Obtener las variables de los otros scripts y sumarlas para obtener la puntuación total
        int puntuacionTotal = (int)scriptPuntuacion.frutastotales + (int)scriptPuntuacion.piedrastotales + Mathf.RoundToInt(scriptContadorTiempo.tiempoRestante);


        // Mostrar la puntuación total en el TextMeshPro
            uiTextPuntuacionTotal.text = "Puntuación Total: " + puntuacionTotal;
        

        // Puedes realizar acciones adicionales con la puntuación total, como guardarla, mostrar un mensaje, etc.
        Debug.Log("Puntuación total: " + puntuacionTotal);
    }
}
