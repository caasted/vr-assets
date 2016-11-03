using UnityEngine;
using System.Collections;

public class FallFromTree : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(-10.5f + 3f * Mathf.Sin(Time.time * 1.0f), 5.7f, -2.9f + 3f * Mathf.Sin(Time.time * 1.0f + 3.14f / 2));
	}
}
