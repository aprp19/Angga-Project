using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour {
	public GameObject DeathText;
	public GameObject DeathButton;
	public GameObject TouchControl;
	private void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.tag == "Fall"){
			DeathText.SetActive(true);
			DeathButton.SetActive(true);
			TouchControl.SetActive(false);
		}
	}
}
