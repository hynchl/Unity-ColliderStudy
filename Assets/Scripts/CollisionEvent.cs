using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionEvent : MonoBehaviour {

    public GameObject iconFactory;
    public GameObject icon;


	private void OnCollisionEnter(Collision collision)
	{
        if (icon == null)
        {
            Vector3 dir = gameObject.transform.position;
            dir.y = 4;

            icon = Instantiate(iconFactory, gameObject.transform);
            icon.transform.position = dir;
        }
	}

    private void OnCollisionStay(Collision collision)
    {

    }

    private void OnCollisionExit(Collision collision)
    {
        Destroy(icon);
    }
}
