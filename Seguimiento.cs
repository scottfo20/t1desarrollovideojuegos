using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // El transform del jugador
   public Vector3 offset = new Vector3(0, 2, -10);


    void LateUpdate()
    {
        // Actualizar la posición de la cámara
        transform.position = player.position + offset;
    }
}

