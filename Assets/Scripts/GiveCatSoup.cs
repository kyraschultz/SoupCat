using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GiveCatSoup : MonoBehaviour
{
    private Inventory inventory;
    private GameObject player;
    private int SoupNum = -1;
    private bool[] cats = new bool[4];

//cat correlates with soup
//moe = carrot
//webster = corn
//coco = wheat berry
//smudge = catnip

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        inventory = player.GetComponent<Inventory>();
    }

    public void disablePanel()
    {
        UnityEngine.Debug.Log("Give Soup: " + SoupNum);
        //need to add a way to identify which soup we are giving and then determine which cat will visit to save for end.
        cats[SoupNum] = true;
        this.transform.parent.gameObject.SetActive(false);
    }

    public void SetSoup(int soup)
    {
        SoupNum = soup;
    }
}
