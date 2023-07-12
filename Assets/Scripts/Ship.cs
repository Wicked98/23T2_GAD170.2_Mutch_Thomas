using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    
   [SerializeField]public List<Crewmate> crewmates = new(); 
    [SerializeField]public Crewmate applyingCrewmate;

    private void Start()
    {
        applyingCrewmate = new Crewmate("Alfred", false, "Likes to go fishing");
    }

    public void OnHireButtonPress()
    {
        Debug.Log("Hire");
        crewmates.Add(applyingCrewmate);
        applyingCrewmate = null;
    }

    public void OnRejectButtonPress()
    {
        Debug.Log("Reject");
    }
}
