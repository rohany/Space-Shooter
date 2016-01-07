using UnityEngine;
using System.Collections;

public class CheckRange : MonoBehaviour {

    // Use this for initialization
    GameObject player;
    Vector3 playerPos;

    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
        playerPos = player.transform.position;
        if (Vector3.Distance(playerPos, transform.position) > 10000f)
        {
            Destroy(gameObject);
        }
    }
}
