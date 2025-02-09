using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private static MainMenuManager instance;

    private void Awake() => instance = this;
    public void CreateLobby()
    {
        BootstrapManager.CreateLobby();
    }
}
