using UnityEngine;

public class ShopTrigger : MonoBehaviour
{

    //\(O w O )/ daisy daisy give me your answer do ~

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ShopManager.instance.ToggleShop();
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ShopManager.instance.ToggleShop();
        }
    }

}
