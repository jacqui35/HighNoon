using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public virtual void Clicked()
    {
        Interact();
    }

    public virtual void Interact()
    {
        Debug.Log("Interacting with base class.");
    }
}
