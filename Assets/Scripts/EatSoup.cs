using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatSoup : MonoBehaviour
{
    private Inventory inventory;
    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        inventory = player.GetComponent<Inventory>();
    }

    public void disablePanel()
    {
        this.transform.parent.gameObject.SetActive(false);
    }
}
