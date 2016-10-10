using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject cube;

	public float spawnRate = 0.5f;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnCube", spawnRate, spawnRate);
	}
	
	// Update is called once per frame
	void SpawnCube () {
		Instantiate (cube, new Vector3 (Random.Range (-10, 10), 10, 0), Quaternion.identity);
	}
}
