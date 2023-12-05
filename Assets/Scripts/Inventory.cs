using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Inventory : MonoBehaviour
{
    public int[] numItem;
    public GameObject[] slots;
    public int[] soupCount;
    public int[] harvestCount;
    public int playerEnergy;
    public bool[] cats = new bool[4];
    public TextMeshProUGUI energyText;

    // Start is called before the first frame update
    void Start()
    {
        //if player energy hits 0, lose condition
        //if player eats catnip, loses 30 energy
        DontDestroyOnLoad(this);
        playerEnergy = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if(energyText)
        {
            energyText.text = "Energy: " + playerEnergy.ToString();
            if (playerEnergy <= 0)
            {
                SceneManager.LoadScene("EnergyDepleted");
                this.transform.position = new Vector3(-500.0f, -500.0f, -500.0f);
            }
        }
    }
}
