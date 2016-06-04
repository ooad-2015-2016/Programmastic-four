using UnityEngine;

public class Spawn1Object : MonoBehaviour {
	public int xMin;
	public int xMax;
	public GameObject[] prefabs;



	private void spawnGhost(){
		int rand = Random.Range (0, 2);
		GameObject ghostToSpawn = prefabs [rand];
		Vector3 newPos = new Vector2 (Random.Range (xMin,xMax), 5);
		GameObject ghost = Instantiate(ghostToSpawn, newPos, Quaternion.identity) as GameObject;
	}
		
	void spamaj(){
		InvokeRepeating ("spawnGhost", 2, 1);
	}


	void Start () {
		spamaj ();
	}
}
