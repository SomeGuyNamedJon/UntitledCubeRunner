using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public Vector3 here;

    // Update is called once per frame
    void Update()
    {
        
        here = player.position + offset;
        transform.position = here;
    }
}
