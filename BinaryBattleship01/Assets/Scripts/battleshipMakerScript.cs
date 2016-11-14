using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class battleshipMakerScript : MonoBehaviour {

	public GameObject Enemyprefab;
	GameObject Enemyprefabclone;

	void Update(){
		Enemyprefabclone=Instantiate(Enemyprefab,transform.position,Quaternion.identity) as GameObject;

	}
}
