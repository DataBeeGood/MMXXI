using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //BB for SceneManager.LoadScene method
#if UNITY_EDITOR
using UnityEditor;  //BB for Conditionals
#endif

// Set this UI script to be executed later than all default scripts
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public ColorPicker ColorPicker;

    public void NewColorSelected(Color color)
    {
        // add code here to handle when a color is selected
		GameDataManager.Instance.TeamColor = color;
    }

    private void Start()
    {
        //Initialize the ColorPicker
		ColorPicker.Init();
        
		//Apply a Color change to the Color Picker
        ColorPicker.onColorChanged += NewColorSelected;
    }

    //BB Load a specified scene using built-in ordered list: Build List 
    public void StartNewScene()
    {
        SceneManager.LoadScene(1); //BB (0) Scene is loaded at Start() 
    }

    //BB Exit the Application
	public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
