using FishNet.Managing;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BootstrapManager : MonoBehaviour
{
    [SerializeField] private string menuName = "MenuSceneSteam";
    [SerializeField] private NetworkManager _networkManager;
    [SerializeField] private FishySteamworks.FishySteamworks _fishySteamworks;
    


    public void GoToMenu() {
        SceneManager.LoadScene(menuName, LoadSceneMode.Additive);
    }
}
