using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector3 cameraPos = Camera.main.transform.position;
		Vector3 cameraRot = Camera.main.transform.forward;

		RaycastHit[] arrayCast = Physics.RaycastAll(new Ray(cameraPos,cameraRot));
		//find the closest hit point that's not zero and make that something along the lines of point
		if (arrayCast.Length > 0) {
			RaycastHit closest = arrayCast [0];
			foreach (RaycastHit hit in arrayCast) {
				if (hit.distance < closest.distance) {
					closest = hit;
				}
			}
			transform.position = closest.point;
		}




	}
}
