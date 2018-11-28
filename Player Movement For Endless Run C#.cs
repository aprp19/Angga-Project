using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	public float moveSpeed;//Kecepatan Player
	public float jumpForce;//Lompatan Player
	private Rigidbody2D myRigidbody;//Tubuh Player

	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody2D>();//Mengambil komponen tubuh player	
	}
	
	// Update is called once per frame
	void Update () {
        //Untuk gerakan ke kanan
		myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);
        //Jika Mouse Button Kiri di klik Player akan lompat
		if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){
			myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
		}
	}
}
