using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AskForName : MonoBehaviour
{

    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _chickenburger;
    
    private string _disease;
    [SerializeField ]private PatientState _patientState;


    // Start is called before the first frame update
    void Start()
    {
        // _patientState = GameObject.FindGameObjectWithTag("Patient").GetComponent<PatientState>();

        _disease = _patientState.getDesease();


    }


    public void askForName ()
    {
        
        _disease = _patientState.getDesease();

        if (_disease.Equals("overdose"))
        {
            print("Works");
            _source.PlayOneShot(_chickenburger);
        }



       
    }
}
