using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    int value;
        private void Start()
    {
        value = Random.Range(5, 10);
    }
        
            
        
   private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ShopManager.instance.coins += value;
            Destroy(gameObject);
        }
    }
}
