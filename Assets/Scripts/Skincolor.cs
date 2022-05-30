using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skincolor : MonoBehaviour
{


    [SerializeField] GameObject _patient;

    // Start is called before the first frame update
    void Start()
    {

        var patientRenderer = _patient.GetComponent<Renderer>();
        patientRenderer.material.color = Color.white;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
