using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{
    public Transform target;  // Referencia al transform del personaje

    public float smoothSpeed = 0.125f;  // Velocidad de suavizado de la cámara

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = new Vector3(target.position.x, transform.position.y, transform.position.z);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }
}
