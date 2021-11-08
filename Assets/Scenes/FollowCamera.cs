using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{   
    [SerializeField] GameObject thingToFollow;
   
    // camera should be same as carguythings position
        void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0,0,-10);
    }
}
