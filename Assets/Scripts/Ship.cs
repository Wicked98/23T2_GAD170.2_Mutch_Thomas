using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Ship : MonoBehaviour
{
    public TextMeshPro nameText;
    public TextMeshPro hobbyText;
    public TextDisplay textDisplay;
    [SerializeField] public List<Crewmate> crewmates = new();
    //[SerializeField] public List<Crewmate> applyingCrewmates = new(); 
    [SerializeField] public Crewmate applyingCrewmate;
    public Transform acceptedParent;
    public GameObject acceptedPrefab;
    private GameObject acceptedObject;

    private void Start()
    {
        CreateCrewmate();
        //textDisplay.AddText("Hello");
    }

    public void OnHireButtonPress()
    {
        Debug.Log("Hire");
       
        // if the crewmate variable has a parasite, then runs the below code 
        if (applyingCrewmate.hasParasite == true)
        {
            // states when the parasite is hired, then tells the UI to print            
            textDisplay.AddText("A parasite has joined your crew!");
            // != = not equals
            // if there's one or more crewmates then run the below code 
            if (crewmates.Count != 0)
            {
                // sets a random crewmate from the crewmate list 
                Crewmate randomCrewmate = crewmates[Random.Range(0, crewmates.Count)];
                // sets a hobby for the randomly chosen crewamate
                string randomCrewmatesHobby = randomCrewmate.crewmateHobby;

                // creating an empty list of crewamtes to later populate with crewmates sharing the same hobby 
                List<Crewmate> sharedHobbiesCrewmates = new();
                // loops through the list of crewmates 
                foreach (var item in crewmates)
                {
                    // the code is run once per crewamate 
                    // comparing the crewmate hobbies to the random crewmate's hobby 
                    if (item.crewmateHobby == randomCrewmatesHobby)
                    {
                        // adding crewmate to the shared hobbies list 
                        sharedHobbiesCrewmates.Add(item);

                    }
                }

                //parasite removes crewmates with shared hobby
                foreach (var item in sharedHobbiesCrewmates)
                {
                    // removes crewmate from the crewmates list 
                    crewmates.Remove(item);
                }
            }

        }


        else
        {
            // states when the human crewmate is hireed, then tells the UI to print  
            textDisplay.AddText("A weak feeble human joined your crew!");
            // adds the hired crewmate to the hired crewmate list  
            crewmates.Add(applyingCrewmate);
            // once the player has hired 10 human crewmates the scene will change to the last scene 
            if (crewmates.Count >= 10)
            {
                SceneManager.LoadScene("Last Scene");
            }
        }
        // clears the applying crewmate variable 
        applyingCrewmate = null;
        // creates crewmate
        
        acceptedObject = Instantiate(acceptedPrefab, acceptedParent);

        Invoke("DeleteAccepted", 2);
        
    }
    public void DeleteAccepted()
    {
        Destroy(acceptedObject);
        CreateCrewmate();
    }
    public void OnRejectButtonPress()
    {
        // if the crewmate hired has a parasite then run the below code
        if (applyingCrewmate.hasParasite == true)
        {
            // states when the human crewmate is rejected, then tells the UI to print 
            if (textDisplay != null)
            {
                textDisplay.AddText("Rejected");
            }
            
        }

        else
        {
            // states when the human crewmate is rejected, then tells the UI to print 
            textDisplay.AddText("Rejected");
        }
       
        Debug.Log("Reject");
        // clears the applying crewmate variable 
        applyingCrewmate = null;
        // creates crewmate
        CreateCrewmate();
        
     

    }

    public void CreateCrewmate()
    {
        // creates crewmate object 
        applyingCrewmate = new Crewmate();
        // sets the new crewmate's name on the resume 
        nameText.text = applyingCrewmate.crewmateName;
        // sets the new crewmate's hobby on the resume 
        hobbyText.text = applyingCrewmate.crewmateHobby;
    }
}

