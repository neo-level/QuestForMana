using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    public string mainMenuScene;
    public string loadGameScene;

	private void Start () {
        AudioManager.instance.PlayBGM(4);
	}
	
    /// <summary>
    /// Returns to the main menu.
    /// </summary>
    public void QuitToMain()
    {
        Destroy(GameManager.instance.gameObject);
        Destroy(PlayerController.instance.gameObject);
        Destroy(GameMenu.instance.gameObject);
        Destroy(AudioManager.instance.gameObject);
        Destroy(BattleManager.instance.gameObject);
        SceneManager.LoadScene(mainMenuScene);
    }

    /// <summary>
    /// Loads last save.
    /// </summary>
    public void LoadLastSave()
    {
        Destroy(GameManager.instance.gameObject);
        Destroy(PlayerController.instance.gameObject);
        Destroy(GameMenu.instance.gameObject);
        SceneManager.LoadScene(loadGameScene);
    }
}
