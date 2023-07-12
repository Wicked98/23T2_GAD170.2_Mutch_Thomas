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
    private List<string> possibleNames = new()
    {
        "Alfred",
        "Tim",
        "Tam",
        "Maurice"
    };
    private List<string> possibleHumanHobbies = new()
    {
        "Likes to go fishing",
        "Tim",
        "Tam",
        "Maurice"
    };
    private List<string> possibleImposterHobbies = new()
    {
        "Alfred",
        "Tim",
        "Tam",
        "Maurice"
    };
    public Crewmate()
    {
        crewmateName = possibleNames[Random.Range(0, possibleNames.Count)];
        if (Random.Range(0, 2)== 0)
        {
            hasParasite = true; 
            crewmateHobby = possibleImposterHobbies[Random.Range(0, possibleImposterHobbies.Count)];
        }
            else
        {
            hasParasite = false; 
            crewmateHobby = possibleHumanHobbies[Random.Range(0, possibleHumanHobbies.Count)]; 
        }
    }

    //public Crewmate(string crewmateName, bool hasParasite, string crewmateHobby)
    //{
    //    this.crewmateName = crewmateName;
    //    this.hasParasite = hasParasite;
    //    this.crewmateHobby = crewmateHobby;
    //}

}
