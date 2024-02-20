using UnityEngine;
using TMPro;

public class GestorPuntuacion : MonoBehaviour
{
    public Puntuacion scriptPuntuacion; // Referencia al script Puntuacion
    public ContadorDeTiempo scriptContadorTiempo; // Referencia al script ContadorDeTiempo
    public TMP_Text uiTextPuntuacionTotal; // Referencia al componente TextMeshPro para mostrar la puntuaci�n total

    void Start()
    {
       
    }

    void Update()
    {
        // Puedes llamar a esta funci�n en respuesta a alg�n evento del juego, como un bot�n de finalizaci�n de nivel
        // Este es solo un ejemplo, puedes llamar a esta funci�n en cualquier momento que desees calcular y mostrar la puntuaci�n total
        
            
        
    }

   public void CalcularPuntuacionTotal()
    {
        // Obtener las variables de los otros scripts y sumarlas para obtener la puntuaci�n total
        int puntuacionTotal = (int)scriptPuntuacion.frutastotales + (int)scriptPuntuacion.piedrastotales + Mathf.RoundToInt(scriptContadorTiempo.tiempoRestante);


        // Mostrar la puntuaci�n total en el TextMeshPro
            uiTextPuntuacionTotal.text = "Puntuaci�n Total: " + puntuacionTotal;
        

        // Puedes realizar acciones adicionales con la puntuaci�n total, como guardarla, mostrar un mensaje, etc.
        Debug.Log("Puntuaci�n total: " + puntuacionTotal);
    }
}
