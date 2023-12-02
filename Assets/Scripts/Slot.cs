using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Button itemButton;
    public int slotNum = -1;
    public Button btn;
    // Start is called before the first frame update
    void Start()
    {
        btn = itemButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void TaskOnClick()
    {
        if (itemButton.tag == "Carrot")
            slotNum = 0;
        else if (itemButton.tag == "Corn")
            slotNum = 1;
        else if (itemButton.tag == "Wheat")
            slotNum = 2;
        else
            slotNum = 3;
    }

    int GetSlotNum()
    { return slotNum; }

}
