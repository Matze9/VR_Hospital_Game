using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cosciousness : MonoBehaviour
{
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _sleepy;

    private string _disease;
    [SerializeField] private PatientState _patientState;


    // Start is called before the first frame update
    void Start()
    {
        
    }


   public void checkConsciousness()
    {
        _disease = _patientState.getDesease();

        if (_disease.Equals("overdose"))
        {
            
            _source.PlayOneShot(_sleepy);
        }
    }
}
