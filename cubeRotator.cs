using UnityEngine;
using System.Collections;

//make sure to make class name as script name (no spaces for name)
public class cubeRotator : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(2, 5, 2);
	}
}
