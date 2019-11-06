﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
    //Player's health
    public GameObject Player;
    public Text healthText;
    public float healthValue = 3;
    public float overHealth = 0;

    private void Text()
    {
        healthText.text = "Health: " + healthValue;
    }

    private void Damage()
    {
        if (healthValue > overHealth)
        {
            Debug.Log("Damage");
        }
        else
        {
            Destroy(Player.gameObject);
        }
    }

    private void OnTriggerEnter(Collider Player)
    {
        healthValue--;
        Text();
        Damage();
    }
}
