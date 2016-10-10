using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {
	
	public float speed = 5;

	// Use this for initialization
	// Start called whenever play is clicked
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (Input.GetAxis ("Horizontal"), 0,0) * Time.deltaTime * speed; //Vector3 is data type that holds xyz
	}

	//if the dropping cube collides with the sphere, the sphere becomes destroyed
	void OnCollisionEnter (Collision col)
	{
		Destroy (gameObject);
	}
}
