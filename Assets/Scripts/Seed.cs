using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Seed : MonoBehaviour
{
    public GameObject player;
    public GameObject itemButton;
    public GameObject thisSeed;
    private Inventory inventory;

    int offset = 1;
    // Start is called before the first frame update
    void Start()
    {
        inventory = player.GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        if((this.transform.position.x - offset < player.transform.position.x && player.transform.position.x < this.transform.position.x + offset) && (this.transform.position.y - offset < player.transform.position.y && player.transform.position.y < this.transform.position.y + offset))
        {
            if (Input.GetKeyDown("e"))
            {
                UnityEngine.Debug.Log("Collect");
                if(thisSeed.tag == "Carrot")
                {
                    Instantiate(itemButton, inventory.slots[0].transform, false);
                    inventory.numItem[0] += 24;
                }
                else if (thisSeed.tag == "Corn")
                {
                    Instantiate(itemButton, inventory.slots[1].transform, false);
                    inventory.numItem[1] += 24;
                }
                else if (thisSeed.tag == "Wheat")
                {
                    Instantiate(itemButton, inventory.slots[2].transform, false);
                    inventory.numItem[2] += 24;
                }
                else
                {
                    Instantiate(itemButton, inventory.slots[3].transform, false);
                    inventory.numItem[3] += 24;
                }
                thisSeed.SetActive(false);
            }
        }
    }
}
