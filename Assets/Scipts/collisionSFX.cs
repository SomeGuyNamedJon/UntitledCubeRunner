using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace cakeslice{
public class collisionSFX : MonoBehaviour
{   
    public static int i;
    public AudioClip[] thuds;
    public AudioSource sfx;
    public PlayerCollision collide;

    private bool soundPlayed = false;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(collide.hitObstacle && !soundPlayed){
            soundPlayed = true;
            sfx.PlayOneShot(thuds[i], 1f);
            if(i != 2){
                i++;
            }else{
                i = 0;
            }
            
        }
    }
}
}
