using UnityEngine;
using System.Collections;

public class Trigger_LibraryPaintings : MonoBehaviour 
{
	public GameObject Painting_Doll2;
	public GameObject Painting_Man;
	public GameObject Painting_man1;

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player"))
		{
			//set the gameobject active
			Painting_Doll2.SetActive (true);
			Painting_Man.SetActive (true);
			Painting_man1.SetActive (true);
			this.gameObject.SetActive (false);
		}
	}

}
