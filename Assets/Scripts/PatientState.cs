using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientState : MonoBehaviour
{

    private string _disease;

    private Desease _dis;


    // Start is called before the first frame update
    void Start()
    {

        //TODO: Create an Array with different diseases and choose random
        _disease = "overdose";

        _dis = new Desease("overdose");
        
    }

    public string getDesease()
    {
        return _dis.getName();
    }

   
}

class Desease 
{
    // Name of the desease
    private string _name;

    public Desease (string name)
    {
        _name = name;
    }

    public string getName()
    {
        return _name;
    }
}
