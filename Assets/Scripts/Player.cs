using UnityEngine;

public class Player : MonoBehaviour
{
    private Controller controller;
    [SerializeField] private int playerNumber;
    private UIPlayerText uiPlayerText;
    public bool HasController => controller != null;
    public int PlayerNumber => playerNumber;

    private void Awake()
    {
        uiPlayerText = GetComponentInChildren<UIPlayerText>();
    }

    public void InitializePlayer(Controller controller)
    {
        this.controller = controller;
        gameObject.name = $"Player {playerNumber} - {controller.gameObject.name}";

        uiPlayerText.HandlePlayerInitialized();
    }
}