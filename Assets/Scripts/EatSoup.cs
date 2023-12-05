using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatSoup : MonoBehaviour
{
    private Inventory inventory;
    private GameObject player;
    private int SoupNum = -1;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        inventory = player.GetComponent<Inventory>();
    }

    public void disablePanel()
    {
        UnityEngine.Debug.Log("Eat Soup: " + SoupNum);
        this.transform.parent.gameObject.SetActive(false);
    }

    public void SetSoup(int soup)
    {
        SoupNum = soup;
    }
}
