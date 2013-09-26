using UnityEngine;
using System.Collections;

public class TouchControle : MonoBehaviour {
	
	private string     _colliderName;
	private LayerMask  _rayMask;
	// Use this for initialization
	void Start () 
	{
		_rayMask = LayerMaskExtensions.Create("IgnoreBall");
		
		
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown(0)) 
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit ;
            if (Physics.Raycast (ray, out hit,100)) 
			{
								
				_colliderName = LayerMask.LayerToName(hit.collider.gameObject.layer);
				if((_colliderName == "FieldLayer" || _colliderName == "TeamBlue")&& TeamManager.SelectedPlayer != null)
				{
					TeamManager.SelectedPlayer.SendMessage("MoveTo",hit.point);
					TeamManager.SelectedPlayer.SendMessage("ClearNames");
					TeamManager.SelectedPlayer = null;
				}else if(_colliderName == "TeamBlue")
				{
					hit.transform.gameObject.SendMessage("ShowName");
					Debug.Log("PlayerSelected");
				}
				else if(TeamManager.SelectedPlayer != null)
				{
					TeamManager.SelectedPlayer.SendMessage("ClearNames");
					TeamManager.SelectedPlayer = null;
				}
            }
		}
	}
}
