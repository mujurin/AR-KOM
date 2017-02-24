using UnityEngine;
using System.Collections;

public class GantiObjek : MonoBehaviour {

	public GameObject objek1,objek2,objek3,objek4,objek5,objek6,objek7,objek8,objek9,objek10,objek11,objek12,objek13,objek14,objek15,objek16,objek17,objek18,objek19,objek20,objek21,objek22,objek23,objek24,objek25,objek26,objek27,objek28,objek29,objek30,objek31,objek32,objek33,objek34,objek35,objek36,objek37,objek38,objek39,objek40,objek41,objek42;
	public GameObject[] objek3D = new GameObject[42];
	public int no = 1;

	//public float kecepatan = 300f;
	
	public Texture start, stop, bagi, next, prev, keluar;
	//, navAtas, navBawah, navKiri, navKanan, 
	private float guiRatio;
	private float sWidth;
	private Vector3 GUIsF;

	public float kecepatanRotasi = 50f;
	bool statusRotasi = false; 
	
	void Awake(){
		sWidth = Screen.width;
		guiRatio = sWidth/1920;
		GUIsF = new Vector3 (guiRatio, guiRatio, 1);
	}

	// Use this for initialization
	void Start () {
		objek3D [0] = objek1;
		objek3D [1] = objek2;
		objek3D [2] = objek3;
		objek3D [3] = objek4;
		objek3D [4] = objek5;
		objek3D [5] = objek6;
		objek3D [6] = objek7;
		objek3D [7] = objek8;
		objek3D [8] = objek9;
		objek3D [9] = objek10;
		objek3D [10] = objek11;
		objek3D [11] = objek12;
		objek3D [12] = objek13;
		objek3D [13] = objek14;
		objek3D [14] = objek15;
		objek3D [15] = objek16;
		objek3D [16] = objek17;
		objek3D [17] = objek18;
		objek3D [18] = objek19;
		objek3D [19] = objek20;
		objek3D [20] = objek21;
		objek3D [21] = objek22;
		objek3D [22] = objek23;
		objek3D [23] = objek24;
		objek3D [24] = objek25;
		objek3D [25] = objek26;
		objek3D [26] = objek27;
		objek3D [27] = objek28;
		objek3D [28] = objek29;
		objek3D [29] = objek30;
		objek3D [30] = objek31;
		objek3D [31] = objek32;
		objek3D [32] = objek33;
		objek3D [33] = objek34;
		objek3D [34] = objek35;
		objek3D [35] = objek36;
		objek3D [36] = objek37;
		objek3D [37] = objek38;
		objek3D [38] = objek39;
		objek3D [39] = objek40;
		objek3D [40] = objek41;
		objek3D [41] = objek42;
	}
	
	public void OnGUI ()
	{
		//Nav ();
		Rotasi();
		Next ();
	}

	void Next()
	{
		GUI.matrix = Matrix4x4.TRS(new Vector3(Screen.width - 258*GUIsF.x,GUIsF.y,0),Quaternion.identity,GUIsF);
		if(GUI.Button(new Rect(-1280, 10, 177, 177), next)) {
			nextObject();
		}
		if(GUI.Button(new Rect(-1600, 10, 177, 177), prev)) {
			prevObject();
		}
		/*
		if(GUI.Button(new Rect(-300, 10, 177, 177), bagi)){
			Application.CaptureScreenshot("HasilCapture.png");
		}
		*/
		if (GUI.Button (new Rect (20, 10, 177, 177), keluar)) {
			Application.Quit();
		}
	}

	void Rotasi(){
		//meletakan button di pojok atas
		GUI.matrix = Matrix4x4.TRS(new Vector3(Screen.width - 258*GUIsF.x,GUIsF.y,0),Quaternion.identity,GUIsF);
		if (statusRotasi == false) {
			if (GUI.Button (new Rect (-300, 10, 177, 177), start)) {
				statusRotasi = true;
			}
		} else {
			if (GUI.Button (new Rect (-300, 10, 177, 177), stop)) {
				statusRotasi = false;
			}
		}
	}


	public void nextObject(){
		if (no < 3){
			no++;
		}
	}
	
	public void prevObject(){
		if (no > 1){	
			no--;
		}
	}

	void Update () {
		//marker meja
		if (no == 1) {
			objek1.SetActive(true);
			objek2.SetActive(false);
			objek3.SetActive(false);
		}
		if (no == 2) {
			objek1.SetActive(false);
			objek2.SetActive(true);
			objek3.SetActive(false);
		}
		if (no == 3) {
			objek1.SetActive(false);
			objek2.SetActive(false);
			objek3.SetActive(true);
		}

		//marker laptop
		if (no == 1) {
			objek4.SetActive(true);
			objek5.SetActive(false);
			objek6.SetActive(false);
		}
		if (no == 2) {
			objek4.SetActive(false);
			objek5.SetActive(true);
			objek6.SetActive(false);
		}
		if (no == 3) {
			objek4.SetActive(false);
			objek5.SetActive(false);
			objek6.SetActive(true);
		}

		//marker kursi
		if (no == 1) {
			objek7.SetActive(true);
			objek8.SetActive(false);
			objek9.SetActive(false);
		}
		if (no == 2) {
			objek7.SetActive(false);
			objek8.SetActive(true);
			objek9.SetActive(false);
		}
		if (no == 3) {
			objek7.SetActive(false);
			objek8.SetActive(false);
			objek9.SetActive(true);
		}

		//marker lampu
		if (no == 1) {
			objek10.SetActive(true);
			objek11.SetActive(false);
			objek12.SetActive(false);
		}
		if (no == 2) {
			objek10.SetActive(false);
			objek11.SetActive(true);
			objek12.SetActive(false);
		}
		if (no == 3) {
			objek10.SetActive(false);
			objek11.SetActive(false);
			objek12.SetActive(true);
		}

		//marker frame foto
		if (no == 1) {
			objek13.SetActive(true);
			objek14.SetActive(false);
			objek15.SetActive(false);
		}
		if (no == 2) {
			objek13.SetActive(false);
			objek14.SetActive(true);
			objek15.SetActive(false);
		}
		if (no == 3) {
			objek13.SetActive(false);
			objek14.SetActive(false);
			objek15.SetActive(true);
		}

		//marker ac
		if (no == 1) {
			objek16.SetActive(true);
			objek17.SetActive(false);
			objek18.SetActive(false);
		}
		if (no == 2) {
			objek16.SetActive(false);
			objek17.SetActive(true);
			objek18.SetActive(false);
		}
		if (no == 3) {
			objek16.SetActive(false);
			objek17.SetActive(false);
			objek18.SetActive(true);
		}

		//marker jam
		if (no == 1) {
			objek19.SetActive(true);
			objek20.SetActive(false);
			objek21.SetActive(false);
		}
		if (no == 2) {
			objek19.SetActive(false);
			objek20.SetActive(true);
			objek21.SetActive(false);
		}
		if (no == 3) {
			objek19.SetActive(false);
			objek20.SetActive(false);
			objek21.SetActive(true);
		}

		//marker bunga
		if (no == 1) {
			objek22.SetActive(true);
			objek23.SetActive(false);
			objek24.SetActive(false);
		}
		if (no == 2) {
			objek22.SetActive(false);
			objek23.SetActive(true);
			objek24.SetActive(false);
		}
		if (no == 3) {
			objek22.SetActive(false);
			objek23.SetActive(false);
			objek24.SetActive(true);
		}

		//marker rakbuku
		if (no == 1) {
			objek25.SetActive(true);
			objek26.SetActive(false);
			objek27.SetActive(false);
		}
		if (no == 2) {
			objek25.SetActive(false);
			objek26.SetActive(true);
			objek27.SetActive(false);
		}
		if (no == 3) {
			objek25.SetActive(false);
			objek26.SetActive(false);
			objek27.SetActive(true);
		}

		//marker rakdinding
		if (no == 1) {
			objek28.SetActive(true);
			objek29.SetActive(false);
			objek30.SetActive(false);
		}
		if (no == 2) {
			objek28.SetActive(false);
			objek29.SetActive(true);
			objek30.SetActive(false);
		}
		if (no == 3) {
			objek28.SetActive(false);
			objek29.SetActive(false);
			objek30.SetActive(true);
		}

		//marker tempatpensil
		if (no == 1) {
			objek31.SetActive(true);
			objek32.SetActive(false);
			objek33.SetActive(false);
		}
		if (no == 2) {
			objek31.SetActive(false);
			objek32.SetActive(true);
			objek33.SetActive(false);
		}
		if (no == 3) {
			objek31.SetActive(false);
			objek32.SetActive(false);
			objek33.SetActive(true);
		}

		//marker tempatsampah
		if (no == 1) {
			objek34.SetActive(true);
			objek35.SetActive(false);
			objek36.SetActive(false);
		}
		if (no == 2) {
			objek34.SetActive(false);
			objek35.SetActive(true);
			objek36.SetActive(false);
		}
		if (no == 3) {
			objek34.SetActive(false);
			objek35.SetActive(false);
			objek36.SetActive(true);
		}

		//marker mapbuku
		if (no == 1) {
			objek37.SetActive(true);
			objek38.SetActive(false);
			objek39.SetActive(false);
		}
		if (no == 2) {
			objek37.SetActive(false);
			objek38.SetActive(true);
			objek39.SetActive(false);
		}
		if (no == 3) {
			objek37.SetActive(false);
			objek38.SetActive(false);
			objek39.SetActive(true);
		}

		//marker printer
		if (no == 1) {
			objek40.SetActive(true);
			objek41.SetActive(false);
			objek42.SetActive(false);
		}
		if (no == 2) {
			objek40.SetActive(false);
			objek41.SetActive(true);
			objek42.SetActive(false);
		}
		if (no == 3) {
			objek40.SetActive(false);
			objek41.SetActive(false);
			objek42.SetActive(true);
		}

		if (statusRotasi == true) {
			objek1.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek2.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek3.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek4.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek5.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek6.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek7.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek8.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek9.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek10.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			
			objek11.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek12.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek13.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek14.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek15.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek16.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek17.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek18.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek19.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek20.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			
			objek21.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek22.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek23.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek24.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek25.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek26.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek27.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek28.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek29.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek30.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			
			objek31.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek32.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek33.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek34.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek35.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek36.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek37.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek38.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek39.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek40.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			
			objek41.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			objek42.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
			
		}
	}
}
