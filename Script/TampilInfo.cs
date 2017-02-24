using UnityEngine;
using System.Collections;
using Vuforia;

public class TampilInfo : MonoBehaviour, ITrackableEventHandler {

	private TrackableBehaviour mTrackableBehaviour;
	
	private bool mShowGUIButton = false;
	public string info;
	
	void Start () {
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}
	}
	
	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
		    newStatus == TrackableBehaviour.Status.TRACKED)
		{
			mShowGUIButton = true;
		}
		else
		{
			mShowGUIButton = false;
		}
	}
	
	void OnGUI() {
		if (mShowGUIButton) {
			GUI.Box(new Rect(20,300,280,160),"Informasi");
			info = GUI.TextArea(new Rect(40,320,240,130),info,200); // menampilkan informasi pada slideshow
		}
	}
}
