using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Title : MonoBehaviour {

    public Text titleObject;
    public string text;
    public GameObject textMesh;
	
	private void OnEnable()
	{
        titleObject.text = text;
        titleObject.enabled = true;
        textMesh.SetActive(true);
	}

	private void OnDisable()
	{
        titleObject.enabled = false;
        textMesh.SetActive(false);
	}
}
