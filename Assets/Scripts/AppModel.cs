using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AppModel : MonoBehaviour 
{
	public int languageID ;
	RuntimePlatform runtimePlatform ;

	void Awake(){
		DontDestroyOnLoad(gameObject.transform);
	}

	void Start(){
		if(PlayerPrefs.HasKey("LanguageID")){
			this.languageID = PlayerPrefs.GetInt("LanguageID");
		}
		else{
			this.languageID = 0;
			PlayerPrefs.SetInt("LanguageID",0);
		}
		this.runtimePlatform = Application.platform;
		SceneManager.LoadScene("Authent");
	}

	public string getWording(int idReference){
		return WordingBackOffice.getText(idReference, this.languageID);
	}
}