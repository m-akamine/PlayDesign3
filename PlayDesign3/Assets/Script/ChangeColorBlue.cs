﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorBlue : MonoBehaviour {

	void OnCollisionEnter(Collision other){
		if(other.gameObject.tag == "Ball"){
			GetComponent<Renderer>().material.color=Color.blue;
		}
	}

}
