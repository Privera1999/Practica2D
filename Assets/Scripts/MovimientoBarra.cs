using UnityEngine;

public class MovimientoBarra : MonoBehaviour
{
    public float velocidad = 2.0f; // Velocidad de movimiento del mu�eco
    public float distancia = 3.0f; // Distancia m�xima a la que se mover� el mu�eco

    private bool moverArriba = true;
    private Vector3 puntoInicial;
    private Vector3 direccion = Vector3.up; // Cambiado a la direcci�n hacia arriba

    private void Start()
    {
        puntoInicial = transform.position; // Guarda la posici�n inicial del mu�eco
    }

    private void Update()
    {
        // Mueve el mu�eco de arriba a abajo dentro de una distancia determinada
        if (moverArriba)
        {
            transform.Translate(direccion * velocidad * Time.deltaTime);
            if (transform.position.y >= puntoInicial.y + distancia)
            {
                moverArriba = false;
                CambiarDireccion(-1f);
            }
        }
        else
        {
            transform.Translate(direccion * velocidad * Time.deltaTime);
            if (transform.position.y <= puntoInicial.y - distancia)
            {
                moverArriba = true;
                CambiarDireccion(1f);
            }
        }
    }

    // Cambia la direcci�n del mu�eco sin cambiar su escala
    private void CambiarDireccion(float y)
    {
        direccion = new Vector3(0, y, 0);
    }
}
