using UnityEngine;
using System.Collections;

public class AsteroidRemoval : MonoBehaviour {

    // Use this for initialization
    public int health;
    public ParticleSystem explosion;
	void Start () {
        health = 100;
	}
	
	// Update is called once per frame
	void Update () {
        if (health <= 0)
        {
            Destroy(gameObject);
            ParticleSystem temp = Instantiate(explosion, transform.position, Quaternion.identity) as ParticleSystem;
            temp.enableEmission = true;
            temp.Play();
            Destroy(temp, 3f);
        }
	}
}
