using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
	public Rigidbody2D rb2d; 
	public PlayerController playercontroller;
	public float moveForce = 5f; 
	public int EnemyCount;
	public Transform enemy; 


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void Awake () {
		rb2d = GetComponent<Rigidbody2D> ();
		EnemyMoveLeft ();
	}
	void FixedUpdate(){
		
	}


	void EnemyMoveLeft(){
		StartCoroutine (AddLeftForce ());

	}
	IEnumerator AddLeftForce(){
		while(true){
			rb2d.AddForce (Vector2.left * moveForce);
			yield return new WaitForSeconds (1);
		}
	}
	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.CompareTag ("Player")) {
			Application.LoadLevel(Application.loadedLevel);
		}  
	}
}
