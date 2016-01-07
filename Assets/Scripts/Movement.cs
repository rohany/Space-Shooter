using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    GameObject cam;
    GameObject player;
    GameObject follower;
    Vector3 rotationOffset;
    Vector3 yaw;
    Vector3 pitch;
    Vector3 targetPos;
    Vector3 strafe;
    public ParticleSystem explosion;
	float velocity = 5f;
    //float boost;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        cam = GameObject.FindGameObjectWithTag("MainCamera");
        follower = GameObject.FindGameObjectWithTag("follower");
        rotationOffset = new Vector3(15, 0 , 0);
        yaw = new Vector3(0, 0, 2);
        pitch = new Vector3(1, 0, 0);
        strafe = new Vector3(0, 1, 0);
        //boost = 1f;
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "asteroid")
        {
            Destroy(gameObject);
            ParticleSystem temp = Instantiate(explosion, transform.position, Quaternion.identity) as ParticleSystem;
            temp.enableEmission = true;
            temp.Play();
            

            //Application.Quit();
        }
    }
    void checkRotate()
    {
		if (velocity <= .1f)
			velocity = .1f;
		if (velocity >= 100f)
			velocity = 100f;
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.Rotate(-1 * strafe);
            //player.transform.rotation = Quaternion.Lerp(player.transform.rotation, player.transform.rotation * Quaternion.Euler(-1*strafe), .5f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.Rotate(strafe);
            //player.transform.rotation = Quaternion.Lerp(player.transform.rotation, player.transform.rotation * Quaternion.Euler(strafe), .5f);
        }
		if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.transform.Rotate(-1 * yaw);
        }
		if (Input.GetKey(KeyCode.RightArrow))
        {
            player.transform.Rotate(yaw);
        }
		if (Input.GetKey(KeyCode.W))
        {
            player.transform.Rotate(-1 * pitch);
        }
        if (Input.GetKey(KeyCode.S))
        {
            player.transform.Rotate(pitch);
        }
		if (Input.GetKey(KeyCode.UpArrow))
		{
			velocity += 5f;
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			velocity -= 5f;
		}
    }
    
	
	// Update is called once per frame
	void Update () {

        checkRotate();
		Vector3 targetPos = (velocity * player.transform.forward) + player.transform.position;
        player.transform.position = Vector3.Lerp(player.transform.position, targetPos, .3f);
        cam.transform.position = follower.transform.position;
        Quaternion rotTarget = player.transform.rotation * Quaternion.Euler(rotationOffset);
        Camera.main.transform.rotation = Quaternion.Lerp(Camera.main.transform.rotation, rotTarget, 10f * Time.deltaTime);

    }
}
