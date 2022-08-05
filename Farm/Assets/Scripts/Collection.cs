using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collection : MonoBehaviour
{
    public GrowthWheat GWheat;
    public GameObject buttom;
    public Animator player;
    public int number;

    private void OnTriggerStay(Collider other)
    {
        if (buttom.activeSelf == false && (GWheat.wheat[number].GetComponent<Growth>().stage == 2 || GWheat.wheat[number].GetComponent<Growth>().stage == 4))
        {
            buttom.SetActive(true);
        }
        else if (buttom.activeSelf == true && GWheat.wheat[number].GetComponent<Growth>().stage != 2 && GWheat.wheat[number].GetComponent<Growth>().stage != 4)
        {
            buttom.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (buttom.activeSelf == true)
        {
            buttom.SetActive(false);
        }
    }
    public void Take(int number)
    {
        if(!player.GetBool("collect"))
        {
            player.Play("collect");
            player.SetBool("collect", true);
        }
        if (GWheat.wheat[number].GetComponent<Growth>().stage == 2)
        {
            GWheat.wheat[number].GetComponent<Growth>().stage = 4;
        }
        else if (GWheat.wheat[number].GetComponent<Growth>().stage == 4)
        {
            GWheat.wheat[number].GetComponent<Growth>().stage = 5;
            player.SetBool("collect", false);
        }
    }
}
