using UnityEngine;
using TMPro;

public class DialogueController : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public void ShowLine(string line)
    {
        dialogueText.text = line;
        dialogueText.gameObject.SetActive(true);
    }
    public void HideLine()
    {
        dialogueText.gameObject.SetActive(false);
    }
}
