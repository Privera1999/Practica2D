using UnityEngine;
using TMPro;

public class ContadorDeTiempo : MonoBehaviour
{
    public float tiempoTotal = 300f; // 5 minutos en segundos
    public float tiempoRestante; // Tiempo restante

    public TMP_Text uiTextTiempo; // Referencia al componente TextMeshPro para el tiempo

    // Otros contadores
    public int contador1;
    public int contador2;

    public TMP_Text uiTextContador1; // Referencia al componente TextMeshPro para el contador 1
    public TMP_Text uiTextContador2; // Referencia al componente TextMeshPro para el contador 2

    private void Start()
    {
        tiempoRestante = tiempoTotal; // Inicializar el tiempo restante al tiempo total al inicio
        ActualizarContador(); // Actualizar el contador visual al inicio
    }

    private void Update()
    {
        if (tiempoRestante > 0)
        {
            tiempoRestante -= Time.deltaTime; // Restar el tiempo transcurrido
            ActualizarContador(); // Actualizar el contador visual si es necesario
        }
        else
        {
            // El tiempo ha alcanzado cero, puedes realizar acciones adicionales aqu�
            Debug.Log("�Tiempo agotado!");
            CalcularPuntuacionTotal();
        }
    }

    void ActualizarContador()
    {
        // Actualizar visualmente el contador de tiempo utilizando TextMeshPro
        if (uiTextTiempo != null)
        {
            uiTextTiempo.text = "Tiempo: " + FormatearTiempo(tiempoRestante);
        }
    }

    void CalcularPuntuacionTotal()
    {
        // Calcular la puntuaci�n total sumando el tiempo restante y los otros dos contadores
        int puntuacionTotal = Mathf.RoundToInt(tiempoRestante) + contador1 + contador2;

        // Mostrar la puntuaci�n total en el TextMeshPro
        Debug.Log("Puntuaci�n total: " + puntuacionTotal);
    }

    public void DetenerContadorYCalcularPuntuacion()
    {
        // Detener el contador y calcular la puntuaci�n total
        tiempoRestante = 0; // Esto detendr� el contador
        CalcularPuntuacionTotal();
    }

    string FormatearTiempo(float segundos)
    {
        // Formatea el tiempo en minutos y segundos
        int minutos = Mathf.FloorToInt(segundos / 60f);
        int segundosRestantes = Mathf.FloorToInt(segundos % 60f);
        return string.Format("{0:0}:{1:00}", minutos, segundosRestantes);
    }
}
