using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSpill : MonoBehaviour
{
    ParticleSystem myParticleSystem;
    //private bool isPouring = false;
    public int pourThreshold = 45;
    public Transform origin;
    // Start is called before the first frame update
    void Start()
    {
        myParticleSystem = GetComponent<ParticleSystem>();
    }
    // Update is called once per frame
    void Update()
    {

        bool pourCheck = (origin.up.y * Mathf.Rad2Deg) < pourThreshold;
        if (pourCheck)
        {
            if(!myParticleSystem.isPlaying) myParticleSystem.Play();

        }
        else
        {
            if (myParticleSystem.isPlaying) myParticleSystem.Stop();
          
        }

    }
}
