using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVomitFX : MonoBehaviour
{

    public ParticleSystem particle;

    //void OnEnable() 
    //{
    //    if (!particle.isPlaying)
    //        {
    //            particle.Play();
    //            Debug.Log("PrintOnEnable: script enabled");
    //    }
        
    //}

    //void OnDisable()
    //{
    //    if (particle.isPlaying)
    //    {
    //        particle.Stop();
    //        Debug.Log("PrintOnDisable: script disabled");
    //    }
    //}

    void Start()
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {

        yield return new WaitForSeconds((float)1.15);

        particle.Play();
    }

}
