using UnityEngine;
using System.Collections;

public class ShotBehavior : MonoBehaviour {

    // Use this for initialization
    Vector3 targetPos;
    GameObject pauser;
    bool isPaused;
	void Start () {
        pauser = GameObject.FindGameObjectWithTag("pauser");
        isPaused = pauser.GetComponent<Pause>().isPaused;
	}
	
	// Update is called once per frame
	void Update () {
        isPaused = pauser.GetComponent<Pause>().isPaused;
        if (!isPaused)
        {
            targetPos = transform.position + (transform.forward * Time.deltaTime * 5000f);

            transform.position = Vector3.Lerp(transform.position, targetPos, 250f);
        }
    }
}
