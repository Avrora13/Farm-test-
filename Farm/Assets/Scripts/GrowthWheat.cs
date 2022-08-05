using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowthWheat : MonoBehaviour
{
    public List<GameObject> prefabs;
    public List<GameObject> wheat;
    public GameObject block;
    public GameObject parent;

    private void Update()
    {
        for(int i = 0; i < wheat.Count; i++)
        {
            if(wheat[i].GetComponent<Growth>().timer >= 5 && wheat[i].GetComponent<Growth>().stage == 0)
            {
                GameObject newGO = Instantiate(prefabs[1], wheat[i].transform.position, wheat[i].transform.rotation);
                newGO.transform.SetParent(parent.transform);
                newGO.GetComponent<Growth>().timer = 5 + Time.deltaTime;
                newGO.GetComponent<Growth>().stage = 1;
                Destroy(wheat[i]);
                wheat[i] = newGO;
            }
            else if (wheat[i].GetComponent<Growth>().timer >= 10 && wheat[i].GetComponent<Growth>().stage == 1)
            {
                GameObject newGO = Instantiate(prefabs[2], wheat[i].transform.position, wheat[i].transform.rotation);
                newGO.transform.SetParent(parent.transform);
                newGO.GetComponent<Growth>().timer = 10 + Time.deltaTime;
                newGO.GetComponent<Growth>().stage = 2;
                Destroy(wheat[i]);
                wheat[i] = newGO;
            }
            else if (wheat[i].GetComponent<Growth>().stage == 4)
            {
                GameObject newGO = Instantiate(prefabs[1], wheat[i].transform.position, wheat[i].transform.rotation);
                newGO.transform.SetParent(parent.transform);
                newGO.GetComponent<Growth>().timer = 10 + Time.deltaTime;
                newGO.GetComponent<Growth>().stage = 4;
                Destroy(wheat[i]);
                wheat[i] = newGO;
            }
            else if (wheat[i].GetComponent<Growth>().stage == 5)
            {
                GameObject newGO = Instantiate(prefabs[0], wheat[i].transform.position, wheat[i].transform.rotation);
                GameObject blockW = Instantiate(block,new Vector3(wheat[i].transform.position.x, wheat[i].transform.position.y, wheat[i].transform.position.z - 2) , wheat[i].transform.rotation);
                blockW.SetActive(true);
                newGO.transform.SetParent(parent.transform);
                newGO.GetComponent<Growth>().timer = 0;
                newGO.GetComponent<Growth>().stage = 0;
                Destroy(wheat[i]);
                wheat[i] = newGO;
            }
        }
    }

    public void SpawnWheat()
    {
        
    }
}
