using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartEvents : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartFirstGame()
    {
        SceneManager.LoadScene(2);
    }

    public void BactToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    
}
