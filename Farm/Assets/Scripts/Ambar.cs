using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ambar : MonoBehaviour
{
    public PlayerController player;
    public GameObject coin;

    private void OnTriggerEnter(Collider other)
    {
        if(coin.activeSelf == false && player.countWheat > 0)
        {
            coin.SetActive(true);
            coin.GetComponent<Animator>().Play("Coin");
        }
    }
}
