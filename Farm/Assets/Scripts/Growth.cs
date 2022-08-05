using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Growth : MonoBehaviour
{
    public float timer = 0;
    public int stage;
    public float dist;

    private void Update()
    {
        if(timer < 10)
        {
            timer += Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Take();
    }

    public void Take()
    {
        if(stage == 2)
        {
            stage = 4;
        }
        else if(stage == 4)
        {
            stage = 5;
        }
    }
}
