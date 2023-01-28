using UnityEngine;
using UnityEngine.UI;

public class PowerUpTimer : MonoBehaviour
{
    public Text countdown;
    public PowerUpController powerUp;

    void Update(){
        if(powerUp.doubleJump && gameObject.tag == "DoubleJump"){
            countdown.text = (powerUp.jumpPowerUpTime).ToString("△0.0");
        }
        if(powerUp.slowTime && gameObject.tag == "TimeSlow"){
            countdown.text = (powerUp.slowPowerUpTime).ToString("▽0.0");
        }
        if(gameObject.tag == "Shield"){
            countdown.text = (powerUp.shieldStack).ToString("▼0");
        }
        
    }
}
