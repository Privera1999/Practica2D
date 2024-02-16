using UnityEngine;

public class MovimientoMu�eco : MonoBehaviour
{
    public float velocidad = 2.0f; // Velocidad de movimiento del mu�eco
    public float distancia = 3.0f; // Distancia m�xima a la que se mover� el mu�eco

    private bool moverDerecha = true;
    private Vector3 puntoInicial;
    private Vector3 direccion = Vector3.right; // Direcci�n inicial del mu�eco

    private void Start()
    {
        puntoInicial = transform.position; // Guarda la posici�n inicial del mu�eco
    }

    private void Update()
    {
        // Mueve el mu�eco de izquierda a derecha dentro de una distancia determinada
        if (moverDerecha)
        {
            transform.Translate(direccion * velocidad * Time.deltaTime);
            if (transform.position.x >= puntoInicial.x + distancia)
            {
                moverDerecha = false;
                CambiarDireccion(-1f);
            }
        }
        else
        {
            transform.Translate(direccion * velocidad * Time.deltaTime);
            if (transform.position.x <= puntoInicial.x - distancia)
            {
                moverDerecha = true;
                CambiarDireccion(1f);
            }
        }
    }

    // Cambia la direcci�n del mu�eco sin cambiar su escala
    private void CambiarDireccion(float x)
    {
        direccion = new Vector3(x, 0, 0);
    }
}