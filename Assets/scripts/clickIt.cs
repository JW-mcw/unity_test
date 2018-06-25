using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickIt : MonoBehaviour {

    private Animation anim;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animation>();
    }

    void OnMouseDown()
    {
        Debug.Log("clicked");

        // this object was clicked - do something
        anim.Play("MV");
    }


    // Update is called once per frame
    void Update () {
		
	}
}
