using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    public GameObject player;
    public GameObject[] plants;
    public GameObject tileLoc;
    private Inventory inventory;
    public bool hasSeed;
    public int slotNum;

    int offset = 1;
    // Start is called before the first frame update
    void Start()
    {
        inventory = player.GetComponent<Inventory>();
        hasSeed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ((this.transform.position.x - offset < player.transform.position.x && player.transform.position.x < this.transform.position.x + offset) && (this.transform.position.y - offset < player.transform.position.y && player.transform.position.y < this.transform.position.y + offset))
        {
            if (Input.GetKeyDown("e"))
            {
                slotNum = 0;
                //when planted we want to put a prefab there, decrease inventory, remove button from slot
                if (inventory.numItem[slotNum] > 0 && !hasSeed)
                {
                    Instantiate(plants[slotNum], tileLoc.transform, false);
                    inventory.numItem[slotNum]--;
                    hasSeed = true;
                }
                
            }
            if (Input.GetKeyDown("r"))
            {
                slotNum = 1;
                //when planted we want to put a prefab there, decrease inventory, remove button from slot
                if (inventory.numItem[slotNum] > 0 && !hasSeed)
                {
                    Instantiate(plants[slotNum], tileLoc.transform, false);
                    inventory.numItem[slotNum]--;
                    hasSeed = true;
                }

            }
            if (Input.GetKeyDown("t"))
            {
                slotNum = 2;
                //when planted we want to put a prefab there, decrease inventory, remove button from slot
                if (inventory.numItem[slotNum] > 0 && !hasSeed)
                {
                    Instantiate(plants[slotNum], tileLoc.transform, false);
                    inventory.numItem[slotNum]--;
                    hasSeed = true;
                }

            }
            if (Input.GetKeyDown("y"))
            {
                slotNum = 3;
                //when planted we want to put a prefab there, decrease inventory, remove button from slot
                if (inventory.numItem[slotNum] > 0 && !hasSeed)
                {
                    Instantiate(plants[slotNum], tileLoc.transform, false);
                    inventory.numItem[slotNum]--;
                    hasSeed = true;
                }

            }
        }
    }
}
