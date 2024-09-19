using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f; // Velocidad del enemigo
    public float moveRange = 3f; // Rango de movimiento
    private Vector2 startPos;

    void Start()
    {
        startPos = transform.position; // Guarda la posición inicial
    }

    void Update()
    {
        // Calcular movimiento de lado a lado
        float newX = startPos.x + Mathf.PingPong(Time.time * speed, moveRange);
        transform.position = new Vector2(newX, transform.position.y);
    }
}
