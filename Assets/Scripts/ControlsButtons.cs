using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlsButtons : MonoBehaviour
{
    public GameObject PanelToDisplay;
    private Inventory inventory;
    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        inventory = player.GetComponent<Inventory>();
    }

    public void displayPanel()
    {
        PanelToDisplay.SetActive(true);
    }
    public void exitPanel()
    { PanelToDisplay.SetActive(false); }

    public void EndScene()
    {
        SceneManager.LoadScene("EndScene");
        player.transform.position = new Vector3(-100f, -100f, -100f);
    }
}
