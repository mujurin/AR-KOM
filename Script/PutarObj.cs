using UnityEngine;
using System.Collections;

public class PutarObj : MonoBehaviour {

	private float guiRatio;
	private float sWidth;
	private Vector3 GUIsF;
	
	public GameObject laptop1;
	public float kecepatanRotasi = 50f;
	bool statusRotasi = false; 
	public Texture start,stop; 
	
	void Awake(){
		sWidth = Screen.width;
		guiRatio = sWidth/1920;
		GUIsF = new Vector3 (guiRatio, guiRatio, 1);
	}
	
	void OnGUI(){
		//memanggil fungsi yang sudah didefinisikan di bawah 
		Rotasi();
	}
	
	void Rotasi(){
		//meletakan button di pojok atas
		GUI.matrix = Matrix4x4.TRS(new Vector3(Screen.width - 258*GUIsF.x,GUIsF.y,0),Quaternion.identity,GUIsF);
		if (statusRotasi == false) {
			if (GUI.Button (new Rect (-154, 675, 177, 177), start)) {
				statusRotasi = true;
			}
		} else {
			if (GUI.Button (new Rect (-154, 675, 177, 177), stop)) {
				statusRotasi = false;
			}
		}
	}
	
	void Update(){
		if (statusRotasi == true) {
			laptop1.transform.Rotate (Vector3.up, kecepatanRotasi * Time.deltaTime);
		}
	}
}
