using UnityEngine;
using System.Collections;

public class EnemyBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<SpriteRenderer> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
