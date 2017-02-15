using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionItem : Interactable {
	public virtual void Interact(){
		Debug.Log("Interacting with Action Item");
	}
}
