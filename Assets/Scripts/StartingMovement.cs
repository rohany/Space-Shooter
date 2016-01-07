using UnityEngine;
using System.Collections;

public class StartingMovement : MonoBehaviour {

    // Use this for initialization
    Vector3 dir;
    Vector3 targetPos;
    GameObject pause;
    bool isPaused;
	void Start () {
        dir = Random.insideUnitSphere * 10f;
        pause = GameObject.FindGameObjectWithTag("pauser");
        isPaused = pause.GetComponent<Pause>().isPaused;
	}
	
	// Update is called once per frame
	void Update () {
        isPaused = pause.GetComponent<Pause>().isPaused;
        if (!isPaused)
        {
            targetPos = transform.position + dir;
            transform.position = Vector3.Lerp(transform.position, targetPos, 10f);
        }
	}
}
