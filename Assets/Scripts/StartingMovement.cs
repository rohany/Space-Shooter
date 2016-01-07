using UnityEngine;
using System.Collections;

public class StartingMovement : MonoBehaviour {

    // Use this for initialization
    Vector3 dir;
    Vector3 targetPos;
	void Start () {
        dir = Random.insideUnitSphere * 10f;
	}
	
	// Update is called once per frame
	void Update () {
        targetPos = transform.position + dir;
        transform.position = Vector3.Lerp(transform.position, targetPos, 10f);
	}
}
