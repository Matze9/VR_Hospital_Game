using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BlanketIsLifted : MonoBehaviour
{

  
   private bool x;

    [SerializeField] private Animator _animator;

    [SerializeField] private PatientState _patientState;
    [SerializeField] private ActionCounter _actionCounter;

    private string _disease;
    private bool _actionMade;


    private void Start()
    {
        x = false;
    }


    public void moveCheck()

      
    {
        x = true;
        
    }


    // Update is called once per frame
    void Update()
    {

        

        if (x == true)
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

            print("Trigger Animation");

            x = false;

        }



    }

    private void makeAction()
    {
        _disease = _patientState.getDesease();

        if (_disease.Equals("overdose"))
        {
            _animator.SetBool("blanketLifted", true);
        }

    }

}


