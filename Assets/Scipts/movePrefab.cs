using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePrefab : MonoBehaviour
{
    
    private float movementSpeed;

    private PowerUpController powerUp;

    void Start(){
        powerUp = FindObjectOfType<PowerUpController>();
        movementSpeed = 15 * GameManager.speedModifier;
    }
    void FixedUpdate()
    {
        if(powerUp.slowTime){
            transform.position = transform.position + new Vector3(0, 0, -(movementSpeed/2) * Time.deltaTime);
            powerUp.slowPowerUpTime -= Time.deltaTime;
            if(powerUp.slowPowerUpTime <= 0){
                powerUp.slowTime = false;
                powerUp.slowPowerUpTime = 5;
            }
        }else{
            transform.position = transform.position + new Vector3(0, 0, -movementSpeed * Time.deltaTime);
        }
    }
}
