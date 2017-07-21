using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour {

    public GameObject Player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Player != null)
        {
            transform.position = new Vector3(Player.transform.position.x, transform.position.y, Player.transform.position.z - 47);
        }


	}
}
