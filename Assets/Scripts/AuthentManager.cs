using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AuthentManager : MonoBehaviour {

	AppModel appModel ;
	LoadingScreen loadingScreen ;
	GameObject loginUI;

	// Use this for initialization
	void Start () {
		this.appModel = GameObject.Find("Application").GetComponent<AppModel>();
		this.loadingScreen = GameObject.Find("LoadingScreen").GetComponent<LoadingScreen>();
		this.loginUI = GameObject.Find("LoginUI");

		this.showBackgroundPopUp(false);
		this.showLoginUI(false);
		this.initLoginUI();

		this.loadingScreen.showLoading();
		this.loadingScreen.hideLoading();

		this.showBackgroundPopUp(true);
		this.showLoginUI(true);
	}
	
	// Update is called once per frame
	void Update () {
		if(this.loadingScreen.toShowLoading){
			this.loadingScreen.addTime(Time.deltaTime);
		}
	}

	void showLoginUI(bool b){
		this.loginUI.SetActive(b);
	}

	void initLoginUI(){
		this.loginUI.transform.FindChild("LoginTitle").GetComponent<TextMeshProUGUI>().text = this.appModel.getWording(0);
		this.loginUI.transform.FindChild("LoginInput").FindChild("Text Area").FindChild("Placeholder").GetComponent<TextMeshProUGUI>().text = this.appModel.getWording(1);
		this.loginUI.transform.FindChild("LoginPassword").FindChild("Text Area").FindChild("Placeholder").GetComponent<TextMeshProUGUI>().text = this.appModel.getWording(2);
	}

	void showBackgroundPopUp(bool b){
		GameObject.Find("BackgroundPopUp").GetComponent<SpriteRenderer>().enabled = b;
	}
}
