using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MacGuffinLocations : MonoBehaviour
{
    public string Location;
    public GameObject ObjectToSpawn;
    public Vector3 SpawnLocation;

    public string Element
    {
        get
        {
            string LocationCheck;
            switch(Location)
            {
                case "Fire":
                    LocationCheck = "Mount Flare";
                    break;
                case "Water":
                    LocationCheck = "Underwater Castle";
                    break;
                default:
                    LocationCheck = "Unknown";
                    break;
            }
            return (LocationCheck);
        }
    }

    public void SpawnObject()
    {
        Instantiate(ObjectToSpawn, SpawnLocation, Quaternion.identity);
    }

    //public 
}
