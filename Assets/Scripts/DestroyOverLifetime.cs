using UnityEngine;

public class DestroyOverLifetime : MonoBehaviour {

    public float lifetime;

	private void Update () {
        Destroy(gameObject, lifetime);
	}
}
