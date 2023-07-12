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
        "Bulma",
        "Human",
        "Tom",
        "Grace",
        "Guy",
        "Jose",
        "Steven",
        "Amina",
        "Alice",
        "Jenny",
        "Fred",
        "Stephanie",
        "Owen",
        "Lumiere",
        "Bella",
        "Josh",
        "Laos",
        "Frodo",
        "Maurice"
    };
    private List<string> possibleHumanHobbies = new()
    {
        "Likes to go fishing",
        "Likes to read",
        "Likes to snow ski",
        "Likes to race",
        "Likes to date",
        "Likes to go clubbing",
        "Likes to watch movies",
        "Likes to write",
        "Likes to sleep in",
        "Likes to drink tea"
    };
    private List<string> possibleImposterHobbies = new()
    {
        "Likes to be human",
        "Likes to eat water",
        "Likes to sky ski",
        "Likes to fly",
        "Likes to drink cheese",
        "Likes to eat hoboms",
        "Likes dancing on the clouds",
        "Likes to eat children",
        "Likes to be walked by dogs",
        "Likes watching radio",
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
