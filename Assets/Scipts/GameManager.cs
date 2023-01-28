using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool playerDead = false;
    public static bool levelWon = true;
    public static int levelCnt = 1;

    public static float speedModifier = 1.0f;
    public static float obstacleSpawnModifier = 1.0f;
    public static float powerUpFrequency = 5.0f;

    public GameObject completeLevelUI;
    public GameObject gameOverUI;

    //public Transform player;

    public Control movement;

    void Start(){
        
        if(levelWon == true){
            levelCnt++;
            levelWon = false;
            speedModifier += 0.25f;
            obstacleSpawnModifier += 0.05f;
            powerUpFrequency -= 0.5f;
        }
    }

    public void GameOver(){
        if(!levelWon){
            playerDead = true;
            levelCnt = 1;
            speedModifier = 1.0f;
            obstacleSpawnModifier = 1.0f;
            powerUpFrequency = 5.0f;
            gameOverUI.SetActive(true);
        }
    }

    public void LevelWin(){
        if(playerDead == false){
            levelWon = true;
            completeLevelUI.SetActive(true);
            Invoke("NextLevel", 1f);
        }
    }

    void NextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}