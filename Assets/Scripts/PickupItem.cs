using UnityEngine;

public class PickupItem : MonoBehaviour {

    private bool canPickup;

	private void Update () {
		if(canPickup && Input.GetButtonDown("Fire1") && PlayerController.instance.canMove)
        {
            GameManager.instance.AddItem(GetComponent<Item>().itemName);
            Destroy(gameObject);
        }
	}

    /// <summary>
    /// Picks item up on interact.
    /// </summary>
    /// <param name="other">Collider2D</param>
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            canPickup = true;
        }
    }

    /// <summary>
    /// Sets picking up items to false.
    /// </summary>
    /// <param name="other">Collider2D</param>
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canPickup = false;
        }
    }
}
