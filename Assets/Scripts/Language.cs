using UnityEngine;
using System.Collections;

public class Language : MonoBehaviour {
	public UIPanel open;
	public UIPanel cur;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnClick()
	{
		cur.gameObject.SetActive (false);
		open.gameObject.SetActive (true);
	}
}
