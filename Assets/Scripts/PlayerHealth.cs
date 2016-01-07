 using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public int startingHealth = 100;
	public int currentHealth;
	public Slider healthSlider;
	public Image damageImage;
	public AudioClip deathClip;
	public float flashSpeed = 5f;
	public Color flashColor = new Color(1f,0f,0f,0.1f);
	AudioSource playerAudio;
	Movement movement;
	bool isDead;
	bool damaged;
	// Use this for initialization
	void Start ()
	{

		//playerAudio = GetComponent <AudioSource>();
		currentHealth = startingHealth;

	}

	// Update is called once per frame
	void Update ()
	{
		if(Random.Range(1f,10f) < 2f)
		{
				TakeDamage(10);
		}
		if(damaged)
		{
			damageImage.color = flashColor;
		}
		else
		{
			damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
		}
		damaged = false;

	}

	public void TakeDamage(int amount)
	{
		damaged = true;
		currentHealth -= amount;
		healthSlider.value = currentHealth;
		if(currentHealth <= 0 && !isDead)
		{

			Death ();

		}




	}

	public void Death()
	{


		isDead = true;
		playerAudio.clip = deathClip;
		playerAudio.Play ();
		movement.enabled = false;

	}
}
