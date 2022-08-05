using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TakeWheat : MonoBehaviour
{
    public PlayerController controller;
    public GameObject parent;
    private void OnTriggerEnter(Collider other)
    {
        if(controller.countWheat < 40 && other == controller.GetComponent<BoxCollider>())
        {
            controller.countWheat += 1;
            Destroy(parent);
        }
    }
}
