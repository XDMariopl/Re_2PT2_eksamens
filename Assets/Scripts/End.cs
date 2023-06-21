using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class End : MonoBehaviour {

	public ObjectScript objectScript;
    public GameObject endtxt;
	private int firstTryCount=0;

	void Start () {
		for(int i = 0;i<StaticVariables.firstTry.Length;i++)
		{
			if (StaticVariables.firstTry[i] == true)
			{
				firstTryCount++;
			}
		}
		endtxt.GetComponent<Text>().text ="Tu atbildeji uz "+firstTryCount+" jautajumiem ar primo piegajienu";
	}
	
}
