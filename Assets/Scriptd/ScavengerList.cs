using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScavengerList : MonoBehaviour {

	public List<GameObject> scavengerHuntList;
	public List<GameObject> cubelist;
	public List<GameObject> spherelist;
	public List<GameObject> capsulelist;


	public Text listDisplay;


	// Use this for initialization
	void Start () {
		
		foreach (GameObject item in scavengerHuntList) 
		{

			switch (item.name) 
			{
			case "Cube":
				cubelist.Add (item);
				break;

			case "Sphere":
				spherelist.Add (item);
				break;

			case "Capsule":
				capsulelist.Add (item);
				break;
			}
		}
			
	}
		
}
