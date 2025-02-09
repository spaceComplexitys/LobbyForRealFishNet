using UnityEngine;
using UnityEngine.SceneManagement;

public class BootstrapManager : MonoBehaviour
{
    [SerializeField] private string menuName = "MenuSceneSteam";

    public void GoToMenu() {
        SceneManager.LoadScene(menuName, LoadSceneMode.Additive);
    }
}
