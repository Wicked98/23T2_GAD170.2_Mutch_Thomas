using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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
        "Likes to sleep till night",
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
        // draws a random name from the list & allocates to the crewmate name variable 
        crewmateName = possibleNames[Random.Range(0, possibleNames.Count)];

        // sets whether the crewmate presented is an imposter, with a 50/50 chance 
        if (Random.Range(0, 2)== 0)
        {
            // sets they have a parasite variable  
            hasParasite = true;
            // sets a random hobby from the list & allocates to the imposter hobby variable 
            crewmateHobby = possibleImposterHobbies[Random.Range(0, possibleImposterHobbies.Count)];
        }
            
            else
        {
            // sets they don't have a parasite variable  
            hasParasite = false;
            // sets a random hobby from the list & allocates to the crewmate hobby variable 
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
