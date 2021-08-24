using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public string newGameScene;

    public GameObject continueButton;

    public string loadGameScene;

	private void Start () {
		if(PlayerPrefs.HasKey("Current_Scene"))
        {
            continueButton.SetActive(true);
        } else
        {
            continueButton.SetActive(false);
        }
	}
	
    /// <summary>
    /// Continues last saved game.
    /// </summary>
    public void Continue()
    {
        SceneManager.LoadScene(loadGameScene);
    }

    /// <summary>
    /// Starts new game.
    /// </summary>
    public void NewGame()
    {
        SceneManager.LoadScene(newGameScene);
    }

    /// <summary>
    /// Exits game.
    /// </summary>
    public void Exit()
    {
        Application.Quit();
    }
}
