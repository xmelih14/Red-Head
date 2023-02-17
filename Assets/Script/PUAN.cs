using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PUAN : MonoBehaviour
{
    public AudioSource Coin;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            Hareket player = collision.gameObject.GetComponent<Hareket>();
            player.score += 1;
            gameObject.SetActive(false);
            Coin.Play();
        }
    }
}
