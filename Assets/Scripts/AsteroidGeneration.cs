using UnityEngine;
using System.Collections;

public class AsteroidGeneration : MonoBehaviour {

    // Use this for initialization
    public GameObject asteroidA;
    public GameObject asteroidB;
    public GameObject asteroidC;
    public GameObject asteroidD;
    public GameObject asteroidE;
    public GameObject asteroidF;
    public GameObject asteroidG;
    public GameObject asteroidH;
    float maxRange;

    //public int numAsteroids
    void Start () {
        maxRange = 10000f;
	    for(int i = 0;i < 20; i++)
        {
            float x = Random.Range(-maxRange, maxRange);
            float y = Random.Range(-maxRange, maxRange);
            float z = Random.Range(-maxRange, maxRange);
            Vector3 pos = new Vector3(x, y, z);
            GameObject asteroid = Instantiate(asteroidA, pos, Random.rotation) as GameObject;
            
        }
        for (int i = 0; i < 20; i++)
        {
            float x = Random.Range(-maxRange, maxRange);
            float y = Random.Range(-maxRange, maxRange);
            float z = Random.Range(-maxRange, maxRange);
            Vector3 pos = new Vector3(x, y, z);
            GameObject asteroid = Instantiate(asteroidB, pos, Random.rotation) as GameObject;
            
        }
        for (int i = 0; i < 20; i++)
        {
            float x = Random.Range(-maxRange, maxRange);
            float y = Random.Range(-maxRange, maxRange);
            float z = Random.Range(-maxRange, maxRange);
            Vector3 pos = new Vector3(x, y, z);
            GameObject asteroid = Instantiate(asteroidC, pos, Random.rotation) as GameObject;
            
        }
        for (int i = 0; i < 20; i++)
        {
            float x = Random.Range(-maxRange, maxRange);
            float y = Random.Range(-maxRange, maxRange);
            float z = Random.Range(-maxRange, maxRange);
            Vector3 pos = new Vector3(x, y, z);
            GameObject asteroid = Instantiate(asteroidD, pos, Random.rotation) as GameObject;
            
        }
        for (int i = 0; i < 20; i++)
        {
            float x = Random.Range(-maxRange, maxRange);
            float y = Random.Range(-maxRange, maxRange);
            float z = Random.Range(-maxRange, maxRange);
            Vector3 pos = new Vector3(x, y, z);
            GameObject asteroid = Instantiate(asteroidE, pos, Random.rotation) as GameObject;
            
        }
        for (int i = 0; i < 20; i++)
        {
            float x = Random.Range(-maxRange, maxRange);
            float y = Random.Range(-maxRange, maxRange);
            float z = Random.Range(-maxRange, maxRange);
            Vector3 pos = new Vector3(x, y, z);
            GameObject asteroid = Instantiate(asteroidF, pos, Random.rotation) as GameObject;
            
        }
        for (int i = 0; i < 20; i++)
        {
            float x = Random.Range(-maxRange, maxRange);
            float y = Random.Range(-maxRange, maxRange);
            float z = Random.Range(-maxRange, maxRange);
            Vector3 pos = new Vector3(x, y, z);
            GameObject asteroid = Instantiate(asteroidG, pos, Random.rotation) as GameObject;
            
        }
        for (int i = 0; i < 20; i++)
        {
            float x = Random.Range(-maxRange, maxRange);
            float y = Random.Range(-maxRange, maxRange);
            float z = Random.Range(-maxRange, maxRange);
            Vector3 pos = new Vector3(x, y, z);
            GameObject asteroid = Instantiate(asteroidH, pos, Random.rotation) as GameObject;
            
        }
    }
	
	// Update is called once per frame
	void Update () {
	    
	}
}
