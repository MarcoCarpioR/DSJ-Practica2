using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform goal;  // El cubo al que va a mirar y moverse
    public float speed = 2f;

    void Update()
    {
        if (goal == null) return;

        // Girar hacia el objetivo
        transform.LookAt(goal.position);

        // Calcular la dirección hacia el objetivo
        Vector3 direction = (goal.position - transform.position).normalized;

        // Moverse hacia el objetivo
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }
}
