using UnityEngine;
using System.Collections;

public class CollisionLasers : MonoBehaviour {

    // Use this for initialization
    //ArrayList<GameObject> asteroids;
    GameObject[] asteroids;
    public ParticleSystem explosion;
    GameObject player;
    int playerHealth;
	void Start () {
        asteroids = GameObject.FindGameObjectsWithTag("asteroid");
        player = GameObject.FindGameObjectWithTag("Player");
	}
  void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "asteroid")
        {
            ParticleSystem tempExplosion = Instantiate(explosion, gameObject.transform.position, Quaternion.identity) as ParticleSystem;
            tempExplosion.enableEmission = true;
            tempExplosion.Play();
            col.gameObject.GetComponent<AsteroidRemoval>().health -= 20;
            Destroy(gameObject);
        }
        if(col.gameObject.tag == "Player"){
            player.GetComponent<PlayerHealth>().currentHealth -= 20;
            ParticleSystem tempExplosion = Instantiate(explosion, gameObject.transform.position, Quaternion.identity) as ParticleSystem;
            tempExplosion.enableEmission = true;
            tempExplosion.Play();
            Destroy(gameObject);
        }
    }
  
	// Update is called once per frame
	void Update () {

	}
}
