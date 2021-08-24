using UnityEngine;

public class DialogActivator : MonoBehaviour {

    public string[] lines;

    private bool canActivate;

    public bool isPerson = true;

    public bool shouldActivateQuest;
    public string questToMark;
    public bool markComplete;


	private void Update () {
		if(canActivate && Input.GetButtonDown("Fire1") && !DialogManager.instance.dialogBox.activeInHierarchy)
        {
            DialogManager.instance.ShowDialog(lines, isPerson);
            DialogManager.instance.ShouldActivateQuestAtEnd(questToMark, markComplete);
        }
	}

    /// <summary>
    /// Allows the player to interact, enabling the dialog screen.
    /// </summary>
    /// <param name="other">Collider2D</param>
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            canActivate = true;
        }
    }

    /// <summary>
    /// Prevents the player from activating the dialog.
    /// </summary>
    /// <param name="other">Collider2D</param>
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canActivate = false;
        }
    }
}
