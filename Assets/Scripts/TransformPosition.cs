using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformPosition : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
        transform.position += Vector3.down * Time.deltaTime;
	}
}
