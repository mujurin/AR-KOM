using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Splash : MonoBehaviour {

	public Transform loadingBar;
	public Transform textIndicator;
	public Transform textLoading;
	[SerializeField] private float currentAmount;
	[SerializeField] private float speed;
	
	// Update is called once per frame
	void Update () {
		
		if (currentAmount < 100) {
			currentAmount += speed * Time.deltaTime;
			textIndicator.GetComponent<Text>().text = ((int)currentAmount).ToString()+"%";
			textLoading.gameObject.SetActive(true);
		} else {
			textLoading.gameObject.SetActive(false);
			textIndicator.GetComponent<Text>().text = "100%" ;
			Application.LoadLevel(1);
		}
		
		loadingBar.GetComponent<Image> ().fillAmount = currentAmount / 100;
		
	}
}
