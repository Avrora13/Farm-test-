using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveMoney : MonoBehaviour
{
    public PlayerController playerController;

    public void Money()
    {
        playerController.money += 15;
        playerController.countWheat -= 1;
        this.gameObject.SetActive(false);
    }
}
