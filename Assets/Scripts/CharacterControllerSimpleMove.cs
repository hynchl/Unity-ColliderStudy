using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerSimpleMove : MonoBehaviour {

    CharacterController cc;

    // Use this for initialization
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        cc.SimpleMove(Vector3.down * Time.deltaTime);
    }
}
