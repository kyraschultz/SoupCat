using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class SeedCollect : MonoBehaviour
{
    public Dictionary<string, int> seedInventory;
    // Start is called before the first frame update
    void Start()
    {
        seedInventory = new Dictionary<string, int>();
        seedInventory.Add("Carrot", 0);
        seedInventory.Add("Corn", 0);
        seedInventory.Add("Wheat", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddSeed(GameObject seed)
    {
        seedInventory[seed.tag] = seedInventory[seed.tag] + 1;
        UnityEngine.Debug.Log("Carrot: " + seedInventory[seed.tag]);
    }
}
