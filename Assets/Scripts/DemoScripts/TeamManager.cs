using UnityEngine;
using System.Collections;

public class TeamManager : MonoBehaviour 
{
	[System.NonSerialized]
	public static GameObject[] Team1;
	public static GameObject   SelectedPlayer = null;
	// Use this for initialization
	void Start () 
	{
		Team1 = GameObject.FindGameObjectsWithTag("Team1");
		Debug.Log("Done");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
