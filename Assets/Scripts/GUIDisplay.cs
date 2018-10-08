using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIDisplay : MonoBehaviour {


	public Texture crispyLogo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI ()
	{
		GUI.Box (new Rect (10,10,100,200), new GUIContent(crispyLogo));
		// Make a background box
		GUI.Box(new Rect(10,115,100,90), "Loader Menu");
		//GUI.Button (new Rect (10,10,100,20), new GUIContent ("Click me", icon, "This is the tooltip"));

		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,145,80,20), "Blue Tundra"))
		{
			//Application.LoadLevel(1);
		}

		// Make the second button.
		if(GUI.Button(new Rect(20,175,80,20), "Red Hilux")) 
		{
			//Application.LoadLevel(2);
		}
	}
}
