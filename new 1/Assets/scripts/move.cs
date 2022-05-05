using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Transforms to act as start and end markers for the journey.
    //public Transform c1;
    //public Transform c2;
    public List<Transform> c;
    int i = 0;

    // Movement speed in units per second.
   float speed = 1.0F;

    // Time when the movement started.
    private float startTime;

    // Total distance between the markers.
    private float journeyLength;
    public float spped1;

    void Start()
    {
        //startTime = Time.time;

       //journeyLength = Vector3.Distance(c[0].position, c[1].position);
    }
           void Update()
    {
        if (Input.GetMouseButton(0))
        {
  
            transform.position = Vector3.Lerp(transform.position, c[i].position,spped1*Time.deltaTime);
            if(transform.position == c[i].position)
            {
                i++;
                if (i == c.Count)
                {
                    i = 0;
                }
            }
        }
        
    }
}
