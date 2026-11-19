using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour {
    [SerializeField] private Vector3 respawnPoint = new Vector3(-8f, 2f, 0f);

    private void OnCollisionEnter(Collision collision) {
        if (!collision.gameObject.CompareTag("Player")) return;

        foreach (ContactPoint contact in collision.contacts) {
            if (contact.normal.y < -0.5f) {
                Rigidbody playerRb = collision.gameObject.GetComponent<Rigidbody>();

                if (playerRb != null) {
                    playerRb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
                }

                Destroy(gameObject);
                return;
            }
        }
        collision.transform.position = respawnPoint;
    }
}
