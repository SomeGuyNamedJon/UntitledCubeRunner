
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text countdown;
    public float timeLeft;

    public GameManager game;

    public Color redish = new Color(0.7f, 0.05f, 0.05f);

    // Update is called once per frame
    void Update()
    {
        if(game.playerDead == true){
            countdown.color = Color.gray;
        }else{
            timeLeft -= Time.deltaTime;
            if (timeLeft > 0){
                if(timeLeft < 6){
                    countdown.color = redish;
                }
                countdown.text = (timeLeft).ToString("0.0");
            }else{
                countdown.color = Color.gray;
                countdown.text = "0.0";
                game.LevelWin();
            }
        }
    }
}
