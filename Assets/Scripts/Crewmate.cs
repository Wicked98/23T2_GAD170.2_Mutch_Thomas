using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// copying classes - right click etc

[System.Serializable]
public class Crewmate 
{
    public string crewmateName;
    public bool hasParasite;
    public string crewmateHobby;

    public Crewmate(string crewmateName, bool hasParasite, string crewmateHobby)
    {
        this.crewmateName = crewmateName;
        this.hasParasite = hasParasite;
        this.crewmateHobby = crewmateHobby;
    }

}
