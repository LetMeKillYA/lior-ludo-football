using UnityEngine;
using System.Collections;

public class PlayerSystem : MonoBehaviour 
{
	
	
	public TextMesh _namePlate;
	public float    _speed;
	
	public enum PlayerStates
	{
		Idle,
		Move,
	}
	
	PlayerStates currentState;
	Vector3      destinationPos;
	// Use this for initialization
	void Start () 
	{
		currentState = PlayerStates.Idle;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(currentState == PlayerStates.Idle)
			return;
		
		switch(currentState)
		{
			case PlayerStates.Move:
				if(transform.position == destinationPos)
					currentState = PlayerStates.Idle;		
				else
					transform.position = Vector3.MoveTowards(transform.position,destinationPos,_speed);
			
				break;
		}
	}
	
	void OnCollisionEnter(Collision colider)
	{
		
	}
	
	public void ShowName()
	{
		ClearNames();
		_namePlate.text 		   = "Selected";
		TeamManager.SelectedPlayer = gameObject;
	}
	
	public void Rename()
	{
		_namePlate.text = "";
	}
	
	public void ClearNames()
	{
		for(int playerNo = 0;playerNo < TeamManager.Team1.Length; playerNo++)
			TeamManager.Team1[playerNo].SendMessage("Rename");
	}
	
	public void MoveTo(Vector3 destPos)
	{
		currentState   = PlayerStates.Move;
		destinationPos = destPos;
	}
}
