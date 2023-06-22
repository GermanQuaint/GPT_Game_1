﻿using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Действия при сборе монеты
            Destroy(gameObject);
        }
    }
}
