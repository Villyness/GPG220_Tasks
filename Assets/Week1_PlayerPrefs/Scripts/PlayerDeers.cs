using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeers : MonoBehaviour
{
    public float PlayerPrefNumber;
    public string PlayerName;

    public float InputNumber;
    public string InputName;

	// Use this for initialization
	void Start ()
    {
        if(PlayerPrefs.HasKey("PlayerName"))
        {
            PlayerName = PlayerPrefs.GetString("PlayerName");
            Debug.Log("Hello World");
        }
        else
        {
            PlayerPrefs.SetString("PlayerName", InputName);
        }
	}
	
    /*public void SavePrefs()
    {
        
    }*/

	// Update is called once per frame
	void Update ()
    {
		
	}
}
