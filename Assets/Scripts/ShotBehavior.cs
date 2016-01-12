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

            targetPos = transform.position + (transform.forward*100f);
            RaycastHit hit;

            transform.position = Vector3.Lerp(transform.position, targetPos, 1000f);
            Vector3 lerpPos = transform.position;
            if(Physics.Raycast(transform.position, lerpPos, out hit)){
              if(hit.transform.gameObject.tag == "asteroid")
              {
                  ParticleSystem tempExplosion = Instantiate(explosion, hit.transform.position, Quaternion.identity) as ParticleSystem;
                  tempExplosion.enableEmission = true;
                  tempExplosion.Play();
                  //col.gameObject.GetComponent<AsteroidRemoval>().health -= 20;
                  hit.transform.gameObject.GetComponent<AsteroidRemoval>().health -= 20;

                  Destroy(gameObject);
              }
              if(hit.transform.gameObject.tag == "Player"){
                  //player.GetComponent<PlayerHealth>().TakeDamage(20);
                  hit.transform.gameObject.GetComponent<PlayerHealth>().TakeDamage(20);
                  //ParticleSystem tempExplosion = Instantiate(explosion, gameObject.transform.position, Quaternion.identity) as ParticleSystem;
                  //tempExplosion.enableEmission = true;
                  //tempExplosion.Play();
                  //Destroy(gameObject);
              }
              /*if(col.gameObject.tag == "enemy"){
                  col.gameObject.GetComponent<EnemyBase>().health -= 20;
                  ParticleSystem tempExplosion = Instantiate(explosion, gameObject.transform.position, Quaternion.identity) as ParticleSystem;
                  tempExplosion.enableEmission = true;
                  tempExplosion.Play();
                  Destroy(gameObject);
              }*/
            }
            transform.position = Vector3.Lerp(transform.position, targetPos, 1000f);
        }
    }
}
