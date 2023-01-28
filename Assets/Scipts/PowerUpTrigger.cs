using UnityEngine;

public class PowerUpTrigger : MonoBehaviour
{
    public AudioClip shieldGet;
    public AudioClip jumpGet;
    public AudioClip slowGet;

    private PowerUpController powerUp;

    void Start(){
        powerUp = FindObjectOfType<PowerUpController>();
    }

    void OnTriggerEnter(Collider collisionInfo){
        if(collisionInfo.tag == "Player"){
            if(gameObject.tag == "TimeSlow"){
                if(powerUp.slowTime == true){
                    powerUp.slowPowerUpTime += 5;
                }else{
                    powerUp.slowPowerUpTime = 5;
                    powerUp.slowTime = true;
                }
                FindObjectOfType<AudioSource>().PlayOneShot(slowGet, 2f);
            }
            if(gameObject.tag == "Shield"){
                if(powerUp.shieldActive == true){
                    powerUp.shieldStack++;
                }else{
                    powerUp.shieldActive = true;
                    powerUp.shieldStack = 1;
                }
                FindObjectOfType<AudioSource>().PlayOneShot(shieldGet, 2f);

            }
            if(gameObject.tag == "DoubleJump"){
                if(powerUp.doubleJump == true){
                    powerUp.jumpPowerUpTime += 10;
                }else{
                    powerUp.jumpPowerUpTime = 10;
                    powerUp.doubleJump = true;
                }
                FindObjectOfType<AudioSource>().PlayOneShot(jumpGet, 1f);
            }

            Destroy(this.gameObject);
        }
    }
}
