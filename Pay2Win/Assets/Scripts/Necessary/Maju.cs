using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	
	public float speed = -1.0f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.RightArrow))
			transform.Translate (speed * Vector2.right * Time.deltaTime);
		else if(Input.GetKey(KeyCode.LeftArrow))
			transform.Translate (-speed * Vector2.right * Time.deltaTime);
	}
}
