using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Diagnose : MonoBehaviour
{

    [SerializeField] private PatientState _patientState;

    [SerializeField] private GameObject _dialogSystem;
    [SerializeField] private GameObject _actionCounter;

    [SerializeField] private GameObject _gameoverCanvas;
    [SerializeField] private TextMeshProUGUI _gameoverText;

    private string _disease;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void makeDiagnose (string answer)
    {
        _disease = _patientState.getDesease();
        _dialogSystem.SetActive(false);
        _actionCounter.SetActive(false);
        _gameoverCanvas.SetActive(true);

        if (_disease.Equals(answer))
        {
            handleWinning();
        } else
        {
            handleLosing();
        }

    }

    private void handleWinning ()
    {
        _gameoverText.SetText("You won!");

    }

    private void handleLosing()
    {
        _gameoverText.SetText("Wrong Diagnose!");
    }
}
