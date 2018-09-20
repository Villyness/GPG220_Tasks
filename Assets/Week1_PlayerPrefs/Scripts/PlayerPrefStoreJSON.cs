using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PlayerPrefStoreJSON :MonoBehaviour
{
    public string InputName;
    public int InputSlot;

    public string CurrentName;
    public int CurrentSlot;

    public Profiles OutputProfiles;
    //public PlayerPrefStore[] CurrentProfile;

	// Use this for initialization
	void Start ()
    {
        /*profile.PlayerName = PlayerPrefs.GetString("CurrentName");
        profile.PlayerSlot = PlayerPrefs.GetInt("CurrentSlot");*/
        //profile.
        //OutputProfiles.profile = CurrentProfile;
        string stringToPrint = JsonUtility.ToJson(OutputProfiles, true);

        File.WriteAllText(Path.Combine(Application.persistentDataPath, "GPG220_MiniTasks.json"), stringToPrint);
        Debug.Log(File.ReadAllText(Path.Combine(Application.persistentDataPath, "GPG220_MiniTasks.json")));
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
