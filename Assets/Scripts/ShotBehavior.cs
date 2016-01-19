using UnityEngine;
using System.Collections;

public class ShotBehavior : MonoBehaviour {

    // Use this for initialization
    Vector3 targetPos;
    GameObject pauser;
    bool isPaused;
    public ParticleSystem explosion;
	void Start () {
        pauser = GameObject.FindGameObjectWithTag("pauser");
        isPaused = pauser.GetComponent<Pause>().isPaused;
	}

	// Update is called once per frame
	void Update () {
        isPaused = pauser.GetComponent<Pause>().isPaused;
        if (!isPaused)
        {
            transform.position = Vector3.Lerp(transform.position, targetPos, 1000f);
        }
    }
}
