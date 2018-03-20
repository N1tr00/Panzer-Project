using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GameManager : NetworkBehaviour
{

    float gameTime = 180;

	void Start ()
    {
		
	}

	void Update ()
    {
        gameTime -= Time.deltaTime;
	}
}
