using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float vel;
	public Rigidbody2D rb;
	public Animator anim;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		vel = 6;
	}

	// Update is called once per frame
	void Update () {
		//vx = vel * Input.GetAxis ("Horizontal");
		//rb.velocity.x = vx;

		Vector2 temp = rb.velocity;
		temp.x = vel * Input.GetAxis("Horizontal");
		rb.velocity = temp;


		Debug.Log (Input.GetAxis("Horizontal"));
		Debug.Log ("vel do rb "+rb.velocity.x);

	}
}
