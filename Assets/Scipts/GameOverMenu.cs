using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void Reset(){
        GameManager.levelWon = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Quit(){
        Application.Quit();
    }

    public void Update(){
        if(Input.GetKeyDown("q")){
            Quit();
        }
        if(Input.GetKeyDown("r")){
            Reset();
        }
    }
}
