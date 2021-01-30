using UnityEngine;

public class UICharacterSelectionMenu : MonoBehaviour
{
    [SerializeField] private UICharacterSelectionPanel leftPanel;
    [SerializeField] private UICharacterSelectionPanel rightPanel;

    public UICharacterSelectionPanel LeftPanel => leftPanel;
    public UICharacterSelectionPanel RightPanel => rightPanel;
}