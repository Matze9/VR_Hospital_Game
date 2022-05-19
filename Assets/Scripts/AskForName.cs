using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AskForName : MonoBehaviour
{

    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _chickenburger;
    
    [SerializeField ]private PatientState _patientState;
    [SerializeField] private ActionCounter _actionCounter;

    private string _disease;
    private bool _actionMade;


    // Start is called before the first frame update
    void Start()
    {
        // _patientState = GameObject.FindGameObjectWithTag("Patient").GetComponent<PatientState>();

        
        _actionMade = false;


    }


    public void askForName ()
    {
        int actionsLeft = _actionCounter.getNumofActionsLeft();

        if(_actionMade == false && actionsLeft > 0)
        {
            _actionCounter.actionMade();
            makeAction();
            _actionMade = true;
        } else if (_actionMade == true)
        {
            makeAction();
        }
        
       
    }

    private void makeAction()
    {
        _disease = _patientState.getDesease();

        if (_disease.Equals("overdose"))
        {
            _source.PlayOneShot(_chickenburger);
        }

    }
}
