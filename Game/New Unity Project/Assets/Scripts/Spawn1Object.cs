using UnityEngine;

public class Spawn1Object : MonoBehaviour {

    private Vector3 startPosition;
    public float moveSpeed = 1f;
    public float moveDistance = 4f;
    public GameObject randomGameObject;

	// Use this for initialization
	void Start () {

        startPosition = transform.position;
        GameObject myObj = Instantiate(randomGameObject) as GameObject;
        myObj.transform.position = transform.position;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
