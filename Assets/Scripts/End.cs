using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class End : MonoBehaviour {
	public GameObject endtxt;

	void Start () {
		endtxt.GetComponent<Text>().text ="You answered "+(StaticVariables.Q-StaticVariables.WrongQ)+" questions correctly";
	}
	
}
