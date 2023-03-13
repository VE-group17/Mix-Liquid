using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PourDetector : MonoBehaviour
{
    public int pourThreshold = 45;
    public Transform origin = null;
    public GameObject streamPrefab = null;

    private bool isPouring = false;
    private Stream currenStream = null;

    private void Update()
    {
        bool pourCheck = CalculatePourAngle() < pourThreshold;
        if(isPouring != pourCheck)
        {
            StartPour();
        }
        else
        {
            EndPour();
        }
        
    }

    private void StartPour()
    {
        print("Start");
        currenStream = CreateStream();
        currenStream.Begin();
    }
    private void EndPour()
    {
        print("End");
    }
    private float CalculatePourAngle()
    {
        return transform.forward.y * Mathf.Rad2Deg;
    }

    private Stream CreateStream()
    {
        GameObject streamObject = Instantiate(streamPrefab, origin.position, Quaternion.identity, transform);
        Stream st = streamObject.AddComponent<Stream>() as Stream;
       
        return streamObject.GetComponent<Stream>();

    }
}
