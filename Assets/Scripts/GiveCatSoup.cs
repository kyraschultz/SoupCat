using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveCatSoup : MonoBehaviour
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
        //need to add a way to identify which soup we are giving and then determine which cat will visit to save for end.
    }
}
