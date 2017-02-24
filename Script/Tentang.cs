using UnityEngine;
using System.Collections;

public class Tentang : MonoBehaviour {

	public GameObject panel,panel2,panel3;

	void Start(){
		panel.SetActive (false);
		panel2.SetActive (false);
		panel3.SetActive (false);
	}

	public void tentangApp(){
		panel.SetActive (true);
		panel2.SetActive (false);
		panel3.SetActive (false);
	}

	public void pembuatApp(){
		panel.SetActive (false);
		panel2.SetActive (true);
		panel3.SetActive (false);
	}

	public void referensiApp(){
		panel.SetActive (false);
		panel2.SetActive (false);
		panel3.SetActive (true);
	}

	public void kembali(){
		Application.LoadLevel (1);
	}
}
