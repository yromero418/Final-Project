using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalFlag : MonoBehaviour {
    [SerializeField] private GameObject levelCompleteText;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            levelCompleteText.SetActive(true);

            PlayerController controller = other.GetComponent<PlayerController>();

            if (controller != null) {
                controller.enabled = false;
            }  
        }
    }
}