﻿using UnityEngine;
using System.Collections;

// ==============================================================================================================================
// newWindow class is used to change the Window
// ==============================================================================================================================

public class newWindow : MonoBehaviour {

	//Strings to hold the Scene names
	public  string  game; 
	public  string  gameTest;
	public  string  SignIn; 
	public  string  Profile; 
	public  string  Main;
	public  string  TutorialScreen;
	public  string  OptionsScreen;


    // ============================================================================================================================== 
    // CHANGETOGAME
    // ==============================================================================================================================

    public void changeToGame() {
		Application.LoadLevel (game);	                // load the game Level
	}


    // ==============================================================================================================================
    // CHANGETOGAMETEST
    // ==============================================================================================================================

    public void changeToGameTest() {		            // testing version of the game
		Application.LoadLevel (gameTest);
	}


    // ==============================================================================================================================
    // CHANGESIGNIN
    // ==============================================================================================================================

    public void changeSignIn() {
		Application.LoadLevel (SignIn);	                // load the game Level
	}


    // ==============================================================================================================================
    // CHANGEPROFILE
    // ==============================================================================================================================

    public void changeProfile() {
		Application.LoadLevel (Profile);	            // load the game Level
	}


    // ==============================================================================================================================
    // CHANGEMAIN
    // ==============================================================================================================================

    public void changeMain() {
		Application.LoadLevel (Main);	                // load the game Level
	}


    // ==============================================================================================================================
    // CHANGETOTUTORIALSCREEN
    // ==============================================================================================================================

    public void changeTutorialScreen() {
		Application.LoadLevel (TutorialScreen);	        // load the Tutorial Screen
	}


    // ==============================================================================================================================
    // CHANGEOPTIONSSCREEN
    // ==============================================================================================================================

    public void changeOptionsScreen() {
		Application.LoadLevel (OptionsScreen);	        // load the Tutorial Screen
	}


    // ==============================================================================================================================
    // QUIT
    // ==============================================================================================================================

    public void quit() {
		Application.Quit();	                            // quit the game 
	}
	

} // end of newWindow