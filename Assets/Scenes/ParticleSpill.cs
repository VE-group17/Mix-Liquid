using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSpill : MonoBehaviour
{
    ParticleSystem myParticleSystem;
    //private bool isPouring = false;
    public int pourThreshold = 45;
    public Transform origin;
    private GameObject bucket;
    private float r;
    private float initial_z;
    bool last_pouring = false;
    bool isPouring = false;
    // Start is called before the first frame update
    void Start()
    {
        myParticleSystem = GetComponent<ParticleSystem>();
        bucket = GameObject.FindGameObjectWithTag("Bucket");
       // r = bucket.transform.localScale.x / 2;
       // initial_z = (float)(bucket.transform.localScale.z *0.5);

        //myParticleSystem.transform.localPosition = origin.localPosition + new Vector3(0, initial_z, 0);


        //print(myParticleSystem.transform.localPosition);
    }
    // Update is called once per frame
    void Update()
    {

        bool pourCheck = (origin.up.y * Mathf.Rad2Deg) < pourThreshold;
       

        if (pourCheck)
        {
            isPouring=true;
         //   print(bucket.transform.localRotation.y) ;
            if(!myParticleSystem.isPlaying) myParticleSystem.Play();
           // print(transform.up);
          //  if (last_pouring != isPouring) {
           //     Quaternion rot = Quaternion.Euler(0, 0, 0);
           //     if (transform.up.x<0.0f) rot = Quaternion.Euler(90, 0, 0);
           //    myParticleSystem.transform.localRotation = rot;

               // myParticleSystem.transform.RotateAround(transform.position, transform.up, 90f * Time.deltaTime);
           // }
           // myParticleSystem.transform.RotateAround(transform.position, transform.parent.loc,135*Time.deltaTime);
            last_pouring = true;
            // float r = bucket.transform.localScale.x / 2;

           // float z = r * Mathf.Cos(bucket.transform.rotation.z);
            //float x = r * Mathf.Cos(bucket.transform.rotation.x);
            //print(bucket.transform.rotation.x);
           // Vector3 new_pos = origin.localPosition + new Vector3(x, initial_z, 0);
           // myParticleSystem.transform.position = origin.position + new Vector3(0, initial_z, 0);
            // print(new_pos);
            //float x = bucket.transform.localScale.x;
            //print(bucket.transform.rotation.z);
            //myParticleSystem.transform.localPosition = new Vector3(myParticleSystem.transform.localPosition.x+x, myParticleSystem.transform.localPosition.y, myParticleSystem.transform.localPosition.z+z); 

        }
        else
        {
            isPouring = false;
            if (myParticleSystem.isPlaying) myParticleSystem.Stop();
            last_pouring=false;
            
          
        }

    }
}
