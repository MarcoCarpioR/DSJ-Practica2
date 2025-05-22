using UnityEngine;

public class MoveToGoal : MonoBehaviour
{
    public Transform goal;
    public float speed = 2f;
    public float accuracy = 0.1f;  // Qué tan cerca está “cerca”

    void Update()
    {
        if (goal == null) return;

        Vector3 direction = goal.position - transform.position;

        if (direction.magnitude > accuracy)
        {
            transform.LookAt(goal.position);
            transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        }
    }
}