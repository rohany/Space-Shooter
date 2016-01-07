using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

    // Use this for initialization
    public bool isPaused;
    Rect pos;
	void Start() {
        isPaused = false;
        pos = new Rect(Screen.width / 2 - Screen.width/4, Screen.height / 2, 500f, 100f);
	}

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;            
        }
	}

    void OnGUI()
    {

        if (isPaused)
        {
            GUI.TextField(pos, "Paused. Press Esc to return to game");
        }

    }

}
