using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ActionCounter : MonoBehaviour
{

    private int _numOfActionsLeft;
    [SerializeField] private TMP_Text _actionsText;

    // Start is called before the first frame update
    void Start()
    {

        _numOfActionsLeft = 3;
        _actionsText.text = _numOfActionsLeft.ToString();
        
    }

    public int getNumofActionsLeft()
    {
        return _numOfActionsLeft;
    }

    public void actionMade ()
    {
        _numOfActionsLeft -= 1;
        _actionsText.text = _numOfActionsLeft.ToString();
    }
}
