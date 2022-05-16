using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AskForName : MonoBehaviour
{

    public AudioSource _source;
    public AudioClip _chickenburger;
    
    private string _disease;
    public PatientState _patientState;

    

   


    // Start is called before the first frame updat
    void Start()
    {
        // _patientState = GameObject.FindGameObjectWithTag("Patient").GetComponent<PatientState>();

        _disease = _patientState.getDesease();

      
    

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void askForName ()
    {

        if (_disease.Equals("overdose"))
        {
            _source.PlayOneShot(_chickenburger);
        }
              
        
    }
}
