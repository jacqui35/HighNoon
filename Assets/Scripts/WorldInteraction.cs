using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldInteraction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) 
            && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject()
            )
        {
            Debug.Log("Pressed left click, casting ray.");
            this.GetInteraction();
        }
		
	}

    void GetInteraction()
    {
        Ray interactionRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit interactionInfo;

        if(Physics.Raycast(interactionRay, out interactionInfo, Mathf.Infinity))
        {
            Debug.Log("Infinity");

            GameObject interactedObject = interactionInfo.collider.gameObject;
            if(interactedObject.tag == "IntObj")
            {
                Debug.Log("IntObj");
                interactedObject.GetComponent<Interactable>().Clicked();
            }
        }
    }
}
