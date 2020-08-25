using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScen : MonoBehaviour
{
    public string NextScen;
	void OnCollisionEnter(Collision other){
		if(other.gameObject.tag == "Ball"){
			SceneManager.LoadScene(NextScen);
		}
	}
}
