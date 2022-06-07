using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nausea_Symptom : MonoBehaviour
{
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _puke;

    [SerializeField] private PatientState _patientState;
    [SerializeField] private ActionCounter _actionCounter;
    [SerializeField] private Animator _animator;

    private string _disease;
    private bool _actionMade;


    // Start is called before the first frame update
    void Start()
    {
        _actionMade = false;
    }


    public void aksIfNauseous()
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
            _source.PlayOneShot(_puke);
            _animator.SetTrigger("puke");
        }

    }
}
