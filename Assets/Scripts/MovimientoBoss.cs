using UnityEngine;

public class MovimientoMuñeco : MonoBehaviour
{
    public float velocidad = 2.0f; // Velocidad de movimiento del muñeco
    public float distancia = 3.0f; // Distancia máxima a la que se moverá el muñeco

    private bool moverDerecha = true;
    private Vector3 puntoInicial;
    private Vector3 direccion = Vector3.right; // Dirección inicial del muñeco

    private void Start()
    {
        puntoInicial = transform.position; // Guarda la posición inicial del muñeco
    }

    private void Update()
    {
        // Mueve el muñeco de izquierda a derecha dentro de una distancia determinada
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

    // Cambia la dirección del muñeco sin cambiar su escala
    private void CambiarDireccion(float x)
    {
        direccion = new Vector3(x, 0, 0);
    }
}