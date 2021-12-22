using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManager : MonoBehaviour
{
// Start() and Update() methods deleted - we don't need them right now

	public static GameDataManager Instance;
	
	public Color TeamColor; // Store the Color selected
	
	private void Awake()
	{
		//make sure only one instance
		if (Instance != null)
		{
			Destroy(gameObject);
			return;
		}
		
		Instance = this;
		DontDestroyOnLoad(gameObject);
	}
}