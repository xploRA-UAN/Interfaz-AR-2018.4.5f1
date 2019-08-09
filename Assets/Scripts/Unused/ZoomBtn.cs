﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomBtn : MonoBehaviour {

	//Scale variable
	public GameObject scale;
	public GUITexture zoomIn;

	//Variables from speed scale n' status of scale
	public float scaleSpeed = 0.02f;
	bool scaleStatus = false;

	public void Scalation(){
		if(scaleStatus==false){
			scaleStatus = true;
		}
		else{
			scaleStatus = false;
		}
	}

	// Update is called once per frame
	void Update () {
		foreach(Touch touch in Input.touches){
			if(touch.phase == TouchPhase.Began && zoomIn.HitTest(touch.position)){
				if(scaleStatus==true){
					//This code line augmented the y's position from gameobject
					scale.transform.localPosition += new Vector3(0, scaleSpeed, 0);
				}
			}
			else if(touch.phase == TouchPhase.Ended){
				scaleStatus = false;
			}
		}
	}
}
