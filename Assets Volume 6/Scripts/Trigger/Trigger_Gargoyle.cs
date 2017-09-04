using UnityEngine;
using System.Collections;

public class Trigger_Gargoyle : MonoBehaviour 
{
	public GameObject FelineGargoyle2;

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player"))
		{
			//set the gameobject active
			FelineGargoyle2.SetActive (true);
			this.gameObject.SetActive (false);
		}
	}

}