using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour {
    [SerializeField] private GameObject dialogueTextObject;
    [SerializeField] private Text dialogueText;

    [TextArea]
    [SerializeField] private string message;

    private bool triggered = false;

    private void OnTriggerEnter(Collider other) {
        if (triggered) return;

        if (other.CompareTag("Player")) {
            triggered = true;
            dialogueTextObject.SetActive(true);
            dialogueText.text = message;
            StartCoroutine(HideDialogue());
        }
    }

    private IEnumerator HideDialogue() {
        yield return new WaitForSeconds(5f);
        dialogueTextObject.SetActive(false);
    }
}
