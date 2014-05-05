using UnityEngine;
using System.Collections;

public class LanguageSelectionG : MonoBehaviour {
	public UIToggle Eng;
	public UIToggle Rus;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnChange()
	{
		if (Eng.startsActive) {
			Localization.instance.currentLanguage = Eng.name;	
		}
		if (Rus.startsActive) {
			Localization.instance.currentLanguage = Eng.name;	
		}
	}
}
