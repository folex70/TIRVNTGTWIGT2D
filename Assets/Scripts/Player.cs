using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float vel;
	public Rigidbody2D rb;
	public Animator anim;
	public SpriteRenderer sprite;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		sprite = GetComponent<SpriteRenderer>();
		vel = 10;
	}

	// Update is called once per frame
	void Update () {
		//vx = vel * Input.GetAxis ("Horizontal");
		//rb.velocity.x = vx;

		anim.SetFloat("vel",Mathf.Abs(Input.GetAxis("Horizontal")));

		Vector2 temp = rb.velocity;
		temp.x = vel * Input.GetAxis("Horizontal");
		rb.velocity = temp;

		//virar 
		if(Input.GetAxis("Horizontal") != 0){
			if(Input.GetAxis("Horizontal") > 0){
				sprite.flipX = false;
			}
			else{
				
				sprite.flipX = true;
			}
		}

	}
}
