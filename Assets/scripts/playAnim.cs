using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAnim : MonoBehaviour {

    //public GameObject Cube;

    public Animation anim;


    // Use this for initialization
    void Start () {
        //anim = Cube.GetComponent<Animation>();
    }

    void OnMouseDown()
    {
        Debug.Log("click");

        // this object was clicked - do something
       anim.Play("MoveUp");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
