using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {


    GameObject player;
    GameObject spawn;
    public GameObject bullet;
    //float speed;

	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        spawn = GameObject.FindGameObjectWithTag("Spawn");
        //speed = 20f;

	}

	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bolt = Instantiate(bullet, spawn.transform.position, spawn.transform.rotation) as GameObject;
        }
	}
}
