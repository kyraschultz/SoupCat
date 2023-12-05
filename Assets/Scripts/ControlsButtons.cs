using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlsButtons : MonoBehaviour
{
    public GameObject PanelToDisplay;

    public void displayPanel()
    {
        PanelToDisplay.SetActive(true);
    }
    public void exitPanel()
    { PanelToDisplay.SetActive(false); }

    public void EndScene()
    {
        SceneManager.LoadScene("EndScene");
    }
}
