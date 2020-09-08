using UnityEngine;
using System.Collections;
using SimpleJSON;
public partial class Wit3D : MonoBehaviour {

	private GameObject dancer;
	private Animator animator;
	private AudioSource[] sounds;
	private AudioSource sound;


	void Handle(string textToParse) {
		sounds = GetComponents<AudioSource>();
		dancer = GameObject.Find("/UserDefinedTarget-1/dancer");
		animator = dancer.GetComponent<Animator>();
		
		print (textToParse);
		var N = JSON.Parse (textToParse);
		print ("SimpleJSON: " + N.ToString());

		string intent = N["intents"] [0] ["name"].Value.ToLower ();

		if (controller.genre == "Hip Hop") {
			sound = sounds[1];
		} else if (controller.genre == "Break Dance") {
			sound = sounds[0];
		} else if (controller.genre == "Salsa") {
			sound = sounds[2];
		}
		sound.pitch = 1.0f;
		switch (intent)
		{
		case "normal_speed":
			animator.SetFloat("speed", 1.0f);
			sound.pitch = 1.0f;
			animator.Play(controller.genre);
			sound.Play();
			break;
		case "slow_down":
			animator.SetFloat("speed", 0.5f);
			sound.pitch = 0.5f;
			animator.Play(controller.genre);
			sound.Play();
			break;
		case "start_dancing":
			animator.Play(controller.genre);
			sound.Play();
			break;
		case "stop":
			animator.Play("idle");
			break;
		case "turn_around":
			dancer.transform.Rotate(0.0f, 180.0f, 0.0f);
			sound.Play();
			break;
		default:
			print ("Sorry, didn't understand your intent.");
			break;
		}


	}
}
