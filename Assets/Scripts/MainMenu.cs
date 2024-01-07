using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame() => SceneManager.LoadScene((int)SceneNames.Scenes.QuestsScene);

    public void ExitGame() => Application.Quit();

}
