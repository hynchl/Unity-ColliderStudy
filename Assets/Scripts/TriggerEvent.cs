using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerEvent : MonoBehaviour {

    public GameObject iconFactory;
    public GameObject icon;


	public void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
	{
        if(icon == null){
            Vector3 dir = gameObject.transform.position;
            dir.y = 4;

            icon = Instantiate(iconFactory, gameObject.transform);
            icon.transform.position = dir;
        }



	}

    private void OnTriggerStay(Collider other)
    {

    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(icon);
    }
}
