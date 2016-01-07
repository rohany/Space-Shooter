using UnityEngine;
using System.Collections;

public class ShotBehavior : MonoBehaviour {

    // Use this for initialization
    Vector3 targetPos;
    
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
        targetPos = transform.position + (transform.forward * Time.deltaTime * 5000f);

        transform.position = Vector3.Lerp(transform.position, targetPos, 250f);
        
    }
}
