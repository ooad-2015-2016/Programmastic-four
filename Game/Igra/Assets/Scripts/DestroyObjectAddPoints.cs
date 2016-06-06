using UnityEngine;
using System.Collections;

public class DestroyObjectAddPoints : MonoBehaviour {

    int myscore = 0;

    void OnTriggerEnter2D (Collider2D collisionObject)
    {
        Destroy(collisionObject.gameObject);
        myscore++;
        Debug.Log("My score is " + myscore + " points.");
    }

}
