using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//BBFIX02 Add SceneManagement namespace to use SceneManager.LoadScene

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public ColorPicker ColorPicker;
    public void NewColorSelected(Color color)
    {
        // add code here to handle when a color is selected
    }

    private void Start()
    {
        ColorPicker.Init();
        //this will call the NewColorSelected function when the color picker have a color button clicked.
        ColorPicker.onColorChanged += NewColorSelected;
    }

    //BBFIX01 Add Method to Menu Handler Script to load Main scene...
    //BBNOTE Scene 0 is Menu Scene 1 is Main see Build Settings the list is according to this order top to bottom
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
}