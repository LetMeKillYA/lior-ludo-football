using UnityEngine;
using System.Collections;

public class AerialCamera : MonoBehaviour 
{
	public Camera topCam;
	
	Vector3 sourcePos,destPos;
	// Use this for initialization
	void Start () 
	{
		topCam.orthographicSize = (30f/854f)*Screen.height;
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(TeamManager.SelectedPlayer != null)
		{
			sourcePos = transform.position;
			destPos   = new Vector3(TeamManager.SelectedPlayer.transform.position.x,transform.position.y,TeamManager.SelectedPlayer.transform.position.z);
			transform.position = Vector3.MoveTowards(sourcePos,destPos,0.4f);
		}
	}
}
