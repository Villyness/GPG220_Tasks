using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefStoreJSON:MonoBehaviour
{
    public string InputName;
    public int InputSlot;

    public string CurrentName;
    public int CurrentSlot;

    public PlayerPrefStore[] profile;

	// Use this for initialization
	void Start ()
    {
        /*profile.PlayerName = PlayerPrefs.GetString("CurrentName");
        profile.PlayerSlot = PlayerPrefs.GetInt("CurrentSlot");*/
        
        string stringToPrint = JsonUtility.ToJson(profile);
 //       Debug.Log(stringToPrint);
	}
	
    public void SavePrefs()
    {
        PlayerPrefs.SetInt("CurrentSlot", InputSlot);
        PlayerPrefs.SetString("CurrentString", InputName);
    }

    public void LoadPrefs()
    {
        PlayerPrefs.SetInt("InputSlot", CurrentSlot);
        PlayerPrefs.SetString("InputName", CurrentName);
    }
}
