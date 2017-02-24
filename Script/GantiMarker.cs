using UnityEngine;
using System.Collections;

public class GantiMarker : MonoBehaviour {

	public GameObject objek1,objek2,objek3,objek4,objek5,objek6,objek7,objek8,objek9,objek10,objek11,objek12,objek13,objek14;
	public GameObject[] objek3D = new GameObject[13];
	public int no = 1;


	public void nextObject(){
		if (no < 14){
			no++;
		}
	}
	
	public void prevObject(){
		if (no > 1){	
			no--;
		}
	}

	public void kembali(){
		Application.LoadLevel (1);
	}

	public void url(){
		Application.OpenURL ("https://drive.google.com/drive/u/0/folders/0B186Vza04fjwYVZWSC1iQ0xTNk0");
	}

	// Use this for initialization
	void Start () {
		objek1.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		if (no == 1) {
			objek1.SetActive(true);
			objek2.SetActive(false);
			objek3.SetActive(false);
			objek4.SetActive(false);
			objek5.SetActive(false);
			objek6.SetActive(false);
			objek7.SetActive(false);
			objek8.SetActive(false);
			objek9.SetActive(false);
			objek10.SetActive(false);
			objek11.SetActive(false);
			objek12.SetActive(false);
			objek13.SetActive(false);
			objek14.SetActive(false);

		}

		if (no == 2) {
			objek1.SetActive(false);
			objek2.SetActive(true);
			objek3.SetActive(false);
			objek4.SetActive(false);
			objek5.SetActive(false);
			objek6.SetActive(false);
			objek7.SetActive(false);
			objek8.SetActive(false);
			objek9.SetActive(false);
			objek10.SetActive(false);
			objek11.SetActive(false);
			objek12.SetActive(false);
			objek13.SetActive(false);
			objek14.SetActive(false);
		}

		if (no == 3) {
			objek1.SetActive(false);
			objek2.SetActive(false);
			objek3.SetActive(true);
			objek4.SetActive(false);
			objek5.SetActive(false);
			objek6.SetActive(false);
			objek7.SetActive(false);
			objek8.SetActive(false);
			objek9.SetActive(false);
			objek10.SetActive(false);
			objek11.SetActive(false);
			objek12.SetActive(false);
			objek13.SetActive(false);
			objek14.SetActive(false);
		}

		if (no == 4) {
			objek1.SetActive(false);
			objek2.SetActive(false);
			objek3.SetActive(false);
			objek4.SetActive(true);
			objek5.SetActive(false);
			objek6.SetActive(false);
			objek7.SetActive(false);
			objek8.SetActive(false);
			objek9.SetActive(false);
			objek10.SetActive(false);
			objek11.SetActive(false);
			objek12.SetActive(false);
			objek13.SetActive(false);
			objek14.SetActive(false);
		}

		if (no == 5) {
			objek1.SetActive(false);
			objek2.SetActive(false);
			objek3.SetActive(false);
			objek4.SetActive(false);
			objek5.SetActive(true);
			objek6.SetActive(false);
			objek7.SetActive(false);
			objek8.SetActive(false);
			objek9.SetActive(false);
			objek10.SetActive(false);
			objek11.SetActive(false);
			objek12.SetActive(false);
			objek13.SetActive(false);
			objek14.SetActive(false);
		}

		if (no == 6) {
			objek1.SetActive(false);
			objek2.SetActive(false);
			objek3.SetActive(false);
			objek4.SetActive(false);
			objek5.SetActive(false);
			objek6.SetActive(true);
			objek7.SetActive(false);
			objek8.SetActive(false);
			objek9.SetActive(false);
			objek10.SetActive(false);
			objek11.SetActive(false);
			objek12.SetActive(false);
			objek13.SetActive(false);
			objek14.SetActive(false);
		}

		if (no == 7) {
			objek1.SetActive(false);
			objek2.SetActive(false);
			objek3.SetActive(false);
			objek4.SetActive(false);
			objek5.SetActive(false);
			objek6.SetActive(false);
			objek7.SetActive(true);
			objek8.SetActive(false);
			objek9.SetActive(false);
			objek10.SetActive(false);
			objek11.SetActive(false);
			objek12.SetActive(false);
			objek13.SetActive(false);
			objek14.SetActive(false);
		}

		if (no == 8) {
			objek1.SetActive(false);
			objek2.SetActive(false);
			objek3.SetActive(false);
			objek4.SetActive(false);
			objek5.SetActive(false);
			objek6.SetActive(false);
			objek7.SetActive(false);
			objek8.SetActive(true);
			objek9.SetActive(false);
			objek10.SetActive(false);
			objek11.SetActive(false);
			objek12.SetActive(false);
			objek13.SetActive(false);
			objek14.SetActive(false);
		}

		if (no == 9) {
			objek1.SetActive(false);
			objek2.SetActive(false);
			objek3.SetActive(false);
			objek4.SetActive(false);
			objek5.SetActive(false);
			objek6.SetActive(false);
			objek7.SetActive(false);
			objek8.SetActive(false);
			objek9.SetActive(true);
			objek10.SetActive(false);
			objek11.SetActive(false);
			objek12.SetActive(false);
			objek13.SetActive(false);
			objek14.SetActive(false);
		}

		if (no == 10) {
			objek1.SetActive(false);
			objek2.SetActive(false);
			objek3.SetActive(false);
			objek4.SetActive(false);
			objek5.SetActive(false);
			objek6.SetActive(false);
			objek7.SetActive(false);
			objek8.SetActive(false);
			objek9.SetActive(false);
			objek10.SetActive(true);
			objek11.SetActive(false);
			objek12.SetActive(false);
			objek13.SetActive(false);
			objek14.SetActive(false);
		}

		if (no == 11) {
			objek1.SetActive(false);
			objek2.SetActive(false);
			objek3.SetActive(false);
			objek4.SetActive(false);
			objek5.SetActive(false);
			objek6.SetActive(false);
			objek7.SetActive(false);
			objek8.SetActive(false);
			objek9.SetActive(false);
			objek10.SetActive(false);
			objek11.SetActive(true);
			objek12.SetActive(false);
			objek13.SetActive(false);
			objek14.SetActive(false);
		}

		if (no == 12) {
			objek1.SetActive(false);
			objek2.SetActive(false);
			objek3.SetActive(false);
			objek4.SetActive(false);
			objek5.SetActive(false);
			objek6.SetActive(false);
			objek7.SetActive(false);
			objek8.SetActive(false);
			objek9.SetActive(false);
			objek10.SetActive(false);
			objek11.SetActive(false);
			objek12.SetActive(true);
			objek13.SetActive(false);
			objek14.SetActive(false);
		}

		if (no == 13) {
			objek1.SetActive(false);
			objek2.SetActive(false);
			objek3.SetActive(false);
			objek4.SetActive(false);
			objek5.SetActive(false);
			objek6.SetActive(false);
			objek7.SetActive(false);
			objek8.SetActive(false);
			objek9.SetActive(false);
			objek10.SetActive(false);
			objek11.SetActive(false);
			objek12.SetActive(false);
			objek13.SetActive(true);
			objek14.SetActive(false);
		}

		if (no == 14) {
			objek1.SetActive(false);
			objek2.SetActive(false);
			objek3.SetActive(false);
			objek4.SetActive(false);
			objek5.SetActive(false);
			objek6.SetActive(false);
			objek7.SetActive(false);
			objek8.SetActive(false);
			objek9.SetActive(false);
			objek10.SetActive(false);
			objek11.SetActive(false);
			objek12.SetActive(false);
			objek13.SetActive(false);
			objek14.SetActive(true);
		}

	
	}
}
