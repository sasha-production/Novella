using UnityEngine;
using UnityEngine.SceneManagement;

public class StartEvents : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartFirstGame()
    {
        SceneManager.LoadScene((int) SceneNames.Scenes.Novell1Scene);
    }

    public void BactToMainMenu()
    {
        SceneManager.LoadScene((int)SceneNames.Scenes.MenuScene);
    }
    
}
