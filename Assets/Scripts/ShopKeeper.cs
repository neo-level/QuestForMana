using UnityEngine;

public class ShopKeeper : MonoBehaviour {

    private bool canOpen;

    public string[] ItemsForSale = new string[40];

	private void Update () {
		if(canOpen && Input.GetButtonDown("Fire1") && PlayerController.instance.canMove && !Shop.instance.shopMenu.activeInHierarchy)
        {
            Shop.instance.itemsForSale = ItemsForSale;

            Shop.instance.OpenShop();
        }
	}

    /// <summary>
    /// Allows to open Shop UI if next to shopkeeper
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            canOpen = true;
        }
    }

    /// <summary>
    /// Prevents to open Shop UI if next to shopkeeper
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canOpen = false;
        }
    }
}
