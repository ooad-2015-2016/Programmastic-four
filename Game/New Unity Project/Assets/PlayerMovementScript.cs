using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour {
	public int speed = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate (Vector2.right * speed * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate (Vector2.left * speed * Time.deltaTime);
		}
	
	}
}
