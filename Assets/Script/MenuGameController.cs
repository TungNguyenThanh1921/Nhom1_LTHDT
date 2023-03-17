using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuGameController : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("MainMap");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void ReturnMenu()
    {
        SceneManager.LoadScene("MenuGame");
    }    
}
