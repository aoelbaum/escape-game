using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arrows : MonoBehaviour {

    public Image arrowImage;
	// Use this for initialization
	void Start ()
    {
        arrowImage.enabled = false;
	}
		

    void OnMouseOver()
    {
        arrowImage.enabled = true;
        Debug.Log("hover on");
        
        
        enabled = true;
    }

    void OnMouseExit()
    {

        arrowImage.enabled = false;


        enabled = true;

    }
}
