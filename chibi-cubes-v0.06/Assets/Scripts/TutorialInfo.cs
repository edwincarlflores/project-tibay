using UnityEngine;
using UnityEngine.UI;
using System.Collections;


// Hi! This script presents the overlay info for our tutorial content, linking you back to the relevant page.
public class TutorialInfo : MonoBehaviour 
{

	// allow user to choose whether to show this menu 
	public bool showAtStart = true;


	// store the GameObject which renders the overlay info
	public GameObject overlay;




	// string to store Prefs Key with name of preference for showing the overlay info
	public static string showAtStartPrefsKey = "showLaunchScreen";


	// show overlay info, pausing game time, disabling the audio listener 
	// and enabling the overlay info parent game object
	public void ShowLaunchScreen()
	{
		Time.timeScale = 0f;
		overlay.SetActive (true);
	}

	// open the stored URL for this content in a web browser

	// continue to play, by ensuring the preference is set correctly, the overlay is not active, 
	// and that the audio listener is enabled, and time scale is 1 (normal)
	public void StartGame()
	{		
		overlay.SetActive (false);
		Time.timeScale = 1f;
	}

	// set the boolean storing show at start status to equal the UI toggle's status

}
