using UnityEngine;
using System.Collections;

public class Crosshair : MonoBehaviour {

    // Use this for initialization
    public Texture2D crosshairTexture;
    Rect pos;
    static bool display = true;
	void Start () {
        //crosshairTexture = Resources.Load("Assets/CrosshairTexture") as Texture2D;
	    pos = new Rect((Screen.width - crosshairTexture.width) / 2, (Screen.height -
         crosshairTexture.height) / 2 - Screen.height/4.5f, crosshairTexture.width, crosshairTexture.height);

    }
	void OnGUI()
    {
        if (display)
        {
            GUI.DrawTexture(pos, crosshairTexture);
        }
    }
	// Update is called once per frame
	void Update () {

	}
}
