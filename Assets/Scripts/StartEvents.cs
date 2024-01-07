using UnityEngine;
using UnityEngine.SceneManagement;

public class StartEvents : MonoBehaviour
{
    public void StartFirstGame() => SceneManager.LoadScene((int)SceneNames.Scenes.Novell1Scene);

    public void BactToMainMenu() => SceneManager.LoadScene((int)SceneNames.Scenes.MenuScene);

}
