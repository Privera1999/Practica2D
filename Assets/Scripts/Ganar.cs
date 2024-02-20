using TMPro;
using UnityEngine;

public class ChangeCameraOnTouch : MonoBehaviour
{
    public GameObject gameOverPanel;
    public TMP_Text uiTextPuntuacionTotal;
    public ContadorDeTiempo contadorDeTiempo;
    public GestorPuntuacion calcularpuntuacion;// Asigna el componente ContadorDeTiempo desde el Inspector

    private void OnTriggerEnter2D(Collider2D other)
    {

        ChangeCamera();
        calcularpuntuacion.CalcularPuntuacionTotal();
    }

    void ChangeCamera()
    {
        gameOverPanel.SetActive(true);
         
    }
}
