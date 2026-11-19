using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [SerializeField] private Transform leftPoint;
    [SerializeField] private Transform rightPoint;
    [SerializeField] private float moveSpeed = 2f;

    private Transform target;

    private void Start() {
        target = rightPoint;
    }

    private void Update() {
        float newX = Mathf.MoveTowards(transform.position.x, target.position.x, moveSpeed * Time.deltaTime);

        transform.position = new Vector3(newX, transform.position.y, transform.position.z);

        if (Mathf.Abs(transform.position.x - target.position.x) < 0.1f) {
            target = target == rightPoint ? leftPoint : rightPoint;
        }
    }
}
