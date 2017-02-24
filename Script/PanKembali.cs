using UnityEngine;
using System.Collections;

public class PanKembali : MonoBehaviour {

	public void gantiMenu (int menu){
		Application.LoadLevel (menu);
	}
}
