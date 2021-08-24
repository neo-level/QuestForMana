using UnityEngine;

public class PlayerLoader : MonoBehaviour {

    public GameObject player;

	private void Start () {
		if(PlayerController.instance == null)
        {
            Instantiate(player);
        }
	}
}
