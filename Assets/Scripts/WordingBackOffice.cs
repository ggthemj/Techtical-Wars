using System;
using System.Collections;
using System.Collections.Generic;

public class WordingBackOffice
{
	public static IList<string[]> texts;

	public static string getText(int idReference, int languageID){
		return texts[idReference][languageID];
	}

	public static string getText(int idReference, List<int> args, int languageID){
		string text = texts[idReference][languageID];
		for(int i = 0;i<args.Count;i++){
			text = text.Replace("ARG"+(i+1),""+args[i]);
		}
		return text;
	}

	static WordingBackOffice ()
	{
		texts = new List<string[]>();
		//0
		texts.Add(new String[]{"Enregistrez-vous à bord","Please check-in to get onboard"});
		texts.Add(new String[]{"Votre login","Your login"});
		texts.Add(new String[]{"Votre mot de passe","Your password"});
	}
}