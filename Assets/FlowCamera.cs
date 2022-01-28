using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowCamera : MonoBehaviour
{
[SerializeField]GameObject thingToFollow;


    // Update is called once per frame
    void LateUpdate()
    {
        //transform.position is for main camera , because we use this script with main camera 
        //vector3 represent x and y and z in player position
        transform.position=thingToFollow.transform.position+new  Vector3(0,0,-10);
    }
}
