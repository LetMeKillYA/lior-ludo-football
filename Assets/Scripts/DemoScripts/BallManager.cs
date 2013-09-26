using UnityEngine;
using System.Collections;

public class BallManager : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		Physics.IgnoreLayerCollision(2,12,true);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
