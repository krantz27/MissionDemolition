using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour {
    public static GameObject POI;
    
    [Header("Set Dynamically")]
    public float camZ;
    // Use this for initialization
    void Awake()
    {
        camZ = this.transform.position.z;
    }

    void FixedUpdate()
    {
        if (POI == null)
        {
            return;
        }
        Vector3 destination = POI.transform.position;
        destination.z = camZ;

        transform.position = destination;

    }
}
