using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *       ___________________________________ ______________________
 *     .' Frankling Marshall es un violador | (_)     (_)    (_)   \
 *   .'  Manuel Mora fumaba cachimba        |  ____          ____   }
 * .',,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,_____|_(    `--------'    )_/ 
 *   El Doctor Moreno Cañas se comio una terciopelo
 *   y se convirtio en el Negro Morgan ...
 * 
 * @rolando <rgarro@gmail.com>
 */
public class GUIDisplay : MonoBehaviour {


	public Texture crispyLogo;
	public float IconX = 10;
    public float IconY = 10;
    public float IconWidth = 128;
    public float IconHeight = 128;
	public int fontSize = 10;
	public int boxY = 115;
	public int boxX = 20;
	public int btnMargin = 5;
	public int boxWidth = 100;
	public int boxHeight = 90;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI ()
	{
		GUIStyle myStyle = new GUIStyle();
		myStyle.fontSize = this.fontSize;

		GUI.Box (new Rect (this.IconX,this.IconY,this.IconWidth,this.IconHeight), new GUIContent(crispyLogo));
		// Make a background box
		GUI.Box(new Rect(this.boxX,this.boxY,this.boxWidth,this.boxHeight), "Loader Menu");
		
		if(GUI.Button(new Rect(this.boxX+this.btnMargin,this.boxY+30,80,20), "Blue Tundra"))
		{
			//Application.LoadLevel(1);
		}

		if(GUI.Button(new Rect(this.boxX+this.btnMargin,this.boxY+60,80,20), "Red Hilux")) 
		{
			//Application.LoadLevel(2);
		}

		if(GUI.Button(new Rect(this.boxX+this.btnMargin,this.boxY+85,80,20), "White Hilux")) 
		{
			//Application.LoadLevel(3);
		}
	}
}
