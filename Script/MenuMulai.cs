using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuMulai : MonoBehaviour {

	public void MulaiAR()
	{
		Application.LoadLevel (2);
	}

	public void Panduan()
	{
		Application.LoadLevel (3);
	}

	public void Tentang()
	{
		Application.LoadLevel (4);
	}

	public void Marker()
	{
		Application.LoadLevel (5);
	}

	public void Keluar()
	{
		Application.Quit ();
	}
}

	/*
	//variable button
	private Button buttonMulai, buttonPanduan, buttonTentang, buttonKeluar;
	
	//variable untuk menambahkan gambar pada slideshow
	public Texture gambar1,gambar2,gambar3,gambar4,gambar5,gambar6;
	
	//variable untuk menambahkan text pada slide show yang dibagi menjadi beberapa bagian (info1,2,3)
	public string info1, info2, info3, info4, info5, info6, info7;
	
	//variable untuk memberikan status panduan apakah sedang aktif(true) atau quit (false)
	public bool menuPanduan = false;
	public bool menuTentang = false;

	//variable untuk mendaftarkan gambar tombol exit
	public Texture exit;

	//script untuk slideshow
	public Vector2 scrollPosition1 = Vector2.zero;
	
	void Start () {
		buttonMulai = this.transform.FindChild("buttonMulai").GetComponent<Button>();
		buttonPanduan = this.transform.FindChild("buttonPanduan").GetComponent<Button>();
		buttonTentang = this.transform.FindChild("buttonTentang").GetComponent<Button>();
		buttonKeluar = this.transform.FindChild("buttonKeluar").GetComponent<Button>();
		
		buttonMulai.RegisterListener(this);
		buttonPanduan.RegisterListener(this);
		buttonTentang.RegisterListener(this);
		buttonKeluar.RegisterListener(this);
	}
	
	public void OnButtonStateChange(Button changedButton, int buttonPhaseId) {
		if (changedButton == buttonMulai) { // jika button touch di tekan
			Application.LoadLevel(2); // pindah ke scene 2 (Menu Augmented Reality Zoo)
		}
		if(changedButton == buttonPanduan) { // jika panduan ditekan
			menuPanduan=true; // slideshow panduan ditampilkan 
		}

		if(changedButton == buttonTentang) { // jika panduan ditekan
			menuTentang=true; // slideshow panduan ditampilkan 
		}

		if (changedButton == buttonKeluar) {
			Application.Quit(); // keluar dari aplikasi
		}
	}
	
	void OnGUI(){

		if(menuPanduan==true){
			
			//membentuk slideshow aplikasi
			GUI.BeginGroup(new Rect(Screen.width/2-200,Screen.height/2-250,800,500));
			GUI.Box(new Rect(0,50,450,400),"Panduan");
			
			if(GUI.Button(new Rect(400, 50, 50, 50),exit)){	
				menuPanduan = false; // jika tombol exit ditekan slideshow akan keluar
			}
			
			scrollPosition1 = GUI.BeginScrollView(new Rect(45,50,350,390),scrollPosition1,new Rect(0,50,2350,200));


			GUI.DrawTexture(new Rect(0,100,350,210),gambar1); // menampilkan gambar pada slideshow
			info1 = GUI.TextArea(new Rect(0,300,350,50),info1,200); // menampilkan informasi pada slideshow
			
			GUI.DrawTexture(new Rect(400,100,350,210),gambar2);
			info2 = GUI.TextArea(new Rect(400,300,350,50),info2,200);
			
			GUI.DrawTexture(new Rect(800,100,350,210),gambar3);
			info3 = GUI.TextArea(new Rect(800,300,350,50),info3,200);

			GUI.DrawTexture(new Rect(1200,100,350,210),gambar4);
			info4 = GUI.TextArea(new Rect(1200,300,350,50),info4,200);

			GUI.DrawTexture(new Rect(1600,100,350,210),gambar5);
			info5 = GUI.TextArea(new Rect(1600,300,350,50),info5,200);

			GUI.DrawTexture(new Rect(2000,100,350,210),gambar6);
			info6 = GUI.TextArea(new Rect(2000,300,350,50),info6,200);


			GUI.EndScrollView();
			GUI.EndGroup();
		}


		if(menuTentang==true){
			
			//membentuk slideshow aplikasi
			GUI.BeginGroup(new Rect(Screen.width/2-200,Screen.height/2-250,800,500));
			GUI.Box(new Rect(0,50,450,360),"Tentang");
			
			if(GUI.Button(new Rect(400, 50, 50, 50),exit)){	
				menuTentang = false; // jika tombol exit ditekan slideshow akan keluar
			}

			GUIStyle myStyle = new GUIStyle(GUI.skin.textField);
			myStyle.alignment = TextAnchor.MiddleCenter;
			info4 = GUI.TextArea(new Rect(50,110,350,250),info7,myStyle); // menampilkan informasi pada slideshow

			GUI.EndGroup();
		}

	}
	*/
