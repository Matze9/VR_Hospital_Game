using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cosciousness : MonoBehaviour
{
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _sleepy;

    private string _disease;
    private bool _actionMade;
    [SerializeField] private ActionCounter _actionCounter;
    [SerializeField] private PatientState _patientState;


    // Start is called before the first frame update
    void Start()
    {
        _actionMade = false;
    }


   public void checkConsciousness()
    {

        int actionsLeft = _actionCounter.getNumofActionsLeft();

        if (_actionMade == false && actionsLeft > 0)
        {
            _actionCounter.actionMade();
            makeAction();
            _actionMade = true;
        }
        else if (_actionMade == true)
        {
            makeAction();
        }

     
    }

    private void makeAction()
    {
      
        _disease = _patientState.getDesease();

        if (_disease.Equals("overdose"))
        {

            _source.PlayOneShot(_sleepy);
        }

    }
}
