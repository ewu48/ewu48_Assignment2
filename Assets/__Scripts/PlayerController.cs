using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public Text countText;
	public Text winText;

    private Rigidbody rb;
    private int score;

    // Use this for initialization
    void Start () {
		rb = GetComponent<Rigidbody>();
		score = 0;
		SetScoreText ();
		winText.text = "";
	}

	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * 8);
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.CompareTag("Red")){
			other.gameObject.SetActive (false);
			score = score + 1;
			SetScoreText ();
		}
		if(other.gameObject.CompareTag("Gray")){
			other.gameObject.SetActive (false);
			score = score + 2;
			SetScoreText ();
		}
		if(other.gameObject.CompareTag("Green")){
			other.gameObject.SetActive (false);
			score = score + 3;
			SetScoreText ();
		}
	}

	void SetScoreText() {
		if (score == 24) {
			winText.text = "You win!";
		}
		countText.text = "Score: " + score.ToString ();
	}
}