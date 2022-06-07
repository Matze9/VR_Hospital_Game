using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answers : MonoBehaviour
{

    private bool _showAnswers;
    [SerializeField] private GameObject _answers;

    // Start is called before the first frame update
    void Start()
    {
        _showAnswers = false;
        _answers.SetActive(_showAnswers);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggleShowAnswers ()
    {
        _showAnswers = !_showAnswers;
        _answers.SetActive(_showAnswers);
        
    }

}
