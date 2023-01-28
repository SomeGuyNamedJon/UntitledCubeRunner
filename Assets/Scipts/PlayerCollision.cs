
using UnityEngine;

namespace cakeslice{
public class PlayerCollision : MonoBehaviour{

    public bool hitObstacle = false;
    public Control movement;
    public Transform player;

    public AudioClip[] shatters;
    public AudioSource sfx;

    public PowerUpController powerUp;

    public Outline shieldOutline;

    void OnCollisionEnter (Collision collisionInfo){
        if(collisionInfo.collider.tag == "Obstacle"){
            hitObstacle = true;
            if(powerUp.shieldActive){
                sfx.PlayOneShot(shatters[collisionSFX.i], .75f);
                Debug.Log("SHIELD BROKEN");
                shieldOutline.eraseRenderer = true;
                powerUp.shieldStack--;
                if(powerUp.shieldStack == 0){
                    powerUp.shieldActive = false;
                }
            }else{
                movement.enabled = false;
                FindObjectOfType<GameManager>().GameOver();
            }
        }
    }

    void Update(){
        if(powerUp.shieldActive){
            shieldOutline.eraseRenderer = false;
        }
        if(player.position.y < 0f){
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
}