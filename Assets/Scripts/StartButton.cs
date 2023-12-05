using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{

    StartMenuControls controls;

    void Awake()
    {
        controls = new StartMenuControls();
        controls.Enable();
    }

    void Update()
    {
        if (controls.StartGame.Play.WasPressedThisFrame())
        {
            // Interact with object
            controls.Disable();
            SceneManager.LoadScene("Main");
            UnityEngine.Debug.Log("Click");
        }
    }
}
