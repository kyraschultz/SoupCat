using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crop : MonoBehaviour
{

    public GameObject CropToYield;
    public GameObject thisCrop;
    public GameObject player;

    int offset = 10;
    int y_offset = 10;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if ((this.transform.position.x - offset < player.transform.position.x && player.transform.position.x < this.transform.position.x + offset) && (this.transform.position.y - y_offset < player.transform.position.y && player.transform.position.y < this.transform.position.y + y_offset))
        {
            if (Input.GetKeyDown("space"))
            {
                Instantiate(CropToYield, thisCrop.transform.parent.transform, false);
                UnityEngine.Debug.Log("Grow");
                thisCrop.SetActive(false);
            }
        }
    }
}
