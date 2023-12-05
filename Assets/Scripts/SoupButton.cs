using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Specialized;

public class SoupButton : MonoBehaviour
{
    private Inventory inventory;
    private GameObject player;
    public Button carrotButton;
    public Button cornButton;
    public Button wheatButton;
    public Button catnipButton;
    public GameObject soupPanel;
    private GameObject canvas;
    private EatSoup eatsoupButton;
    private GiveCatSoup giveCatButton;
    
    // Start is called before the first frame update
    void Start()
    {
        //countText = slot.GetComponent<TextMeshProUGUI>();
        player = GameObject.FindGameObjectWithTag("Player");
        canvas = GameObject.FindGameObjectWithTag("Canvas");
        inventory = player.GetComponent<Inventory>();
        carrotButton.onClick.AddListener(CarrotSoup);
        cornButton.onClick.AddListener(CornSoup);
        wheatButton.onClick.AddListener(WheatSoup);
        catnipButton.onClick.AddListener(CatnipSoup);
    }

    private void CarrotSoup()
    {
        if (inventory.harvestCount[0] >= 4 && this.tag == "Carrot")
        {
            UnityEngine.Debug.Log("Carrot Soup");
            inventory.harvestCount[0] -= 4;
            inventory.soupCount[0]++;
            Instantiate(soupPanel, canvas.transform, false);
            eatsoupButton = GameObject.FindGameObjectWithTag("EatSoup").GetComponent<EatSoup>();
            giveCatButton = GameObject.FindGameObjectWithTag("GiveSoup").GetComponent<GiveCatSoup>();
            eatsoupButton.SetSoup(0);
            giveCatButton.SetSoup(0);
            //countText.text = inventory.harvestCount[0].ToString();
        }
    }
    private void CornSoup()
    {
        if (inventory.harvestCount[1] >= 4 && this.tag == "Corn")
        {
            inventory.harvestCount[1] -= 4;
            inventory.soupCount[1]++;
            UnityEngine.Debug.Log("Corn Soup");
            Instantiate(soupPanel, canvas.transform, false);
            eatsoupButton = GameObject.FindGameObjectWithTag("EatSoup").GetComponent<EatSoup>();
            giveCatButton = GameObject.FindGameObjectWithTag("GiveSoup").GetComponent<GiveCatSoup>();
            eatsoupButton.SetSoup(1);
            giveCatButton.SetSoup(1);
            //countText.text = inventory.harvestCount[1].ToString();
        }
    }
    private void WheatSoup()
    {
        if (inventory.harvestCount[2] >= 4 && this.tag == "Wheat")
        {
            inventory.harvestCount[2] -= 4;
            inventory.soupCount[2]++;
            UnityEngine.Debug.Log("Wheat Berry Soup");
            Instantiate(soupPanel, canvas.transform, false);
            eatsoupButton = GameObject.FindGameObjectWithTag("EatSoup").GetComponent<EatSoup>();
            giveCatButton = GameObject.FindGameObjectWithTag("GiveSoup").GetComponent<GiveCatSoup>();
            eatsoupButton.SetSoup(2);
            giveCatButton.SetSoup(2);
            //countText.text = inventory.harvestCount[2].ToString();
        }
    }
    private void CatnipSoup()
    {
        if (inventory.harvestCount[3] >= 4 && this.tag == "Catnip")
        {
            inventory.harvestCount[3] -= 4;
            inventory.soupCount[3]++;
            UnityEngine.Debug.Log("Catnip Soup");
            Instantiate(soupPanel, canvas.transform, false);
            eatsoupButton = GameObject.FindGameObjectWithTag("EatSoup").GetComponent<EatSoup>();
            giveCatButton = GameObject.FindGameObjectWithTag("GiveSoup").GetComponent<GiveCatSoup>();
            eatsoupButton.SetSoup(3);
            giveCatButton.SetSoup(3);
            //countText.text = inventory.harvestCount[3].ToString();
        }
    }

   
    // Update is called once per frame
    void Update()
    {
    }
}
