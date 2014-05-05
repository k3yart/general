using UnityEngine;
using System.Collections;

public class OptionMenuController : MonoBehaviour {
     public UIPanel currentPanel;
	 public UIPanel menuPanel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void back()
	{
		currentPanel.gameObject.SetActive (false);
		menuPanel.gameObject.SetActive (true);
	}
}
