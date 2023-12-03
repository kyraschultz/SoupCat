using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Seed : MonoBehaviour
{
    private GameObject player;
    public GameObject itemButton;
    public GameObject thisSeed;
    private Inventory inventory;

    int offset = 5;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
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
                else if (thisSeed.tag == "Catnip")
                {
                    Instantiate(itemButton, inventory.slots[3].transform, false);
                    inventory.numItem[3] += 24;
                }
                else if (thisSeed.tag == "Carrot1")
                {
                    Instantiate(itemButton, inventory.slots[4].transform, false);
                    inventory.numItem[4] += 3;
                }
                else if (thisSeed.tag == "Corn1")
                {
                    Instantiate(itemButton, inventory.slots[5].transform, false);
                    inventory.numItem[5] += 3;
                }
                else if (thisSeed.tag == "Wheat1")
                {
                    Instantiate(itemButton, inventory.slots[6].transform, false);
                    inventory.numItem[6] += 3;
                }
                else if (thisSeed.tag == "Catnip1")
                {
                    Instantiate(itemButton, inventory.slots[7].transform, false);
                    inventory.numItem[7] += 3;
                }

                thisSeed.SetActive(false);
            }
        }
    }
}
