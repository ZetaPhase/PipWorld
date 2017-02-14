using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldInteraction : MonoBehaviour {

	UnityEngine.AI.NavMeshAgent playerAgent;

	// Use this for initialization
	void Start () {
		playerAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(1) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject()){
			GetInteraction();
		}
	}

	void GetInteraction()
	{
		Ray interactionRay = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit interactionInfo;
		if (Physics.Raycast(interactionRay, out interactionInfo, Mathf.Infinity)){
			GameObject interactedObject = interactionInfo.collider.gameObject;
			if(interactedObject.tag == "Interactable Object")
			{
				Debug.Log("Interactable interacted.");
			}else{
				playerAgent.destination = interactionInfo.point;
			}
		}
	}
}
