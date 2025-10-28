using TMPro;
using UnityEngine;

public class DialogueController : MonoBehaviour {
    public TextMeshProUGUI dialogueText; // chỉ trỏ tới TextMeshProUGUI bên trong BubbleChat
    public GameObject bubbleChat;        // trỏ tới BubbleChat (Image + Tail)

    public void ShowDialogue(string text)
    {
        dialogueText.text = text;
        bubbleChat.SetActive(true);  // bật toàn bộ bubble (Image + Tail + Text)
    }

    public void HideDialogue()
    {
        bubbleChat.SetActive(false);
    }
}
