using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Sub : MonoBehaviour
{
    public TextMeshProUGUI subtitleText;

    public void ShowSubtitle(string text)
    {
        subtitleText.text = text;
    }

    public void ClearSubtitle()
    {
        subtitleText.text = "";
    }
}
