using UnityEngine;
using TMPro;

public class DialogueController : MonoBehaviour {
    public TextMeshProUGUI dialogueText;
    public BubbleFollow bubbleFollow;
    public Transform main;
    public Transform wifeSoul;

    private Transform currentSpeaker;

    public void SetSpeakerToMain()
    {
        currentSpeaker = main;
    }

    public void SetSpeakerToWife()
    {
        currentSpeaker = wifeSoul;
    }

    public void ShowDialogue(string text)
    {
        if (dialogueText == null || bubbleFollow == null)
        {
            Debug.LogWarning("DialogueText hoặc BubbleFollow chưa được gán!");
            return;
        }

        dialogueText.text = text;
        dialogueText.gameObject.transform.parent.gameObject.SetActive(true); // bật cả BubbleChat
        dialogueText.gameObject.SetActive(true);

        if (currentSpeaker != null)
            bubbleFollow.SetTarget(currentSpeaker);
        else
            Debug.LogWarning("Chưa gọi SetSpeakerToMain/Wife trước khi ShowDialogue!");
    }

    public void HideDialogue()
    {
        dialogueText.gameObject.transform.parent.gameObject.SetActive(false);
    }
}
