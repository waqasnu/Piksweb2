using UnityEngine;
using UnityEngine.Advertisements;


public class ads : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Advertisement.Show();

		InvokeRepeating("Countdown", 60, 61);

	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void Countdown () {
		Advertisement.Show();
	}
}
