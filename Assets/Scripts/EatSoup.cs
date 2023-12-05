using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatSoup : MonoBehaviour
{
    private Inventory inventory;
    private GameObject player;
    private int SoupNum = -1;
    private GameObject canvas;
    public GameObject panelToDisplay;
    public GameObject catnipPanel;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        inventory = player.GetComponent<Inventory>();
        canvas = GameObject.FindGameObjectWithTag("Canvas");
    }

    public void disablePanel()
    {
        UnityEngine.Debug.Log("Eat Soup: " + SoupNum);
        if(SoupNum < 3)
        {
            if(SoupNum == 0)
            {
                inventory.playerEnergy += 10;
            }
            else
            {
                inventory.playerEnergy += 15;
            }
            if (inventory.playerEnergy > 100)
            {
                inventory.playerEnergy = 100;
            }
        }
        else
        {
            inventory.playerEnergy -= 20;
        }
        this.transform.parent.gameObject.SetActive(false);
    }

    public void displayPanel()
    {
        if (SoupNum < 3)
        {
            Instantiate(panelToDisplay, canvas.transform, false);
        }
        else
        {
            Instantiate(catnipPanel, canvas.transform, false);
        }
    }

    public void SetSoup(int soup)
    {
        SoupNum = soup;
    }
}
