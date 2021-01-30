using System.Collections;
using TMPro;
using UnityEngine;

public class UIPlayerText : MonoBehaviour
{
    private TextMeshProUGUI tmText;

    private void Awake()
    {
        tmText = GetComponent<TextMeshProUGUI>();
    }

    public void HandlePlayerInitialized()
    {
        tmText.SetText("Player joined!");
        StartCoroutine(ClearTextAfterDelay());
    }

    private IEnumerator ClearTextAfterDelay()
    {
        yield return new WaitForSeconds(2f);
        tmText.SetText("");
    }
}