using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatReveals : MonoBehaviour
{
    private Inventory inventory;
    private GameObject player;
    public GameObject catCard;
    public GameObject catDisplay;
    public GameObject mysteryDisplay;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        inventory = player.GetComponent<Inventory>();
        if (catCard.tag == "Moe")
        {
            if (inventory.cats[0] == true)
            {
                catDisplay.SetActive(true);
            }
            else
            {
                mysteryDisplay.SetActive(true);
            }
        }
        if (catCard.tag == "Webster")
        {
            if (inventory.cats[1] == true)
            {
                catDisplay.SetActive(true);
            }
            else
            {
                mysteryDisplay.SetActive(true);
            }
        }
        if (catCard.tag == "Coco")
        {
            if (inventory.cats[2] == true)
            {
                catDisplay.SetActive(true);
            }
            else
            {
                mysteryDisplay.SetActive(true);
            }
        }
        if (catCard.tag == "Smudge")
        {
            if (inventory.cats[3] == true)
            {
                catDisplay.SetActive(true);
            }
            else
            {
                mysteryDisplay.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
