using UnityEngine;
using System.Collections;

public class EnemyBase : MonoBehaviour {

	// Use this for initialization
	public int health;
	float fireDelay;
	public GameObject laser;
	public GameObject laserSpawn;
	public GameObject pauser;
	public GameObject player;
	bool isPaused;
	float velocity;
	float lastShot;
	Vector3 targetPos;
	void Start () {
			health = 100;
			fireDelay = .5f;
			lastShot = 0f;
			//velocity = player.GetComponent<Movement>().velocity;
			velocity = 5f;
			isPaused = pauser.GetComponent<Pause>().isPaused;
	}
	bool findPlayer(){
			//rudimentary ai for the moment

			if(Vector3.Distance(player.transform.position, transform.position) < 10000f){
					transform.LookAt(player.transform);
					return true;
			}
			else{
					return false;
			}
	}
	// Update is called once per frame
	void Update () {
			isPaused = pauser.GetComponent<Pause>().isPaused;
			//velocity = player.GetComponent<Movement>().velocity;
			if(!isPaused){
					if(true){
							transform.LookAt(player.transform);
						  targetPos = velocity * transform.forward + transform.position;
							transform.position = Vector3.Lerp(transform.position, targetPos, .3f);
							if(Time.unscaledTime - lastShot >= fireDelay){
									GameObject bullet = Instantiate(laser, laserSpawn.transform.position, transform.rotation) as GameObject;
							}
					}
			}
	}
}
