using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ship : MonoBehaviour
{
    public TextMeshPro nameText;
    public TextMeshPro hobbyText;
    [SerializeField] public List<Crewmate> crewmates = new();
    //[SerializeField] public List<Crewmate> applyingCrewmates = new(); 
    [SerializeField] public Crewmate applyingCrewmate;

    private void Start()
    {
        CreateCremate();

    }

    public void OnHireButtonPress()
    {
        Debug.Log("Hire");
        crewmates.Add(applyingCrewmate);
        applyingCrewmate = null;
        CreateCremate();

    }

    public void OnRejectButtonPress()
    {
        Debug.Log("Reject");
        applyingCrewmate = null;
        CreateCremate();

    }

    public void CreateCremate()
    {
        applyingCrewmate = new Crewmate();
        nameText.text = applyingCrewmate.crewmateName;
        hobbyText.text = applyingCrewmate.crewmateHobby;
    }
}

