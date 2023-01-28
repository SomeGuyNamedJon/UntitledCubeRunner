using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play(){
        SceneManager.LoadScene("Level01");
    }

    public void About(){
        SceneManager.LoadScene("About");
    }

    public void Quit(){
        Application.Quit();
    }

    public void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            Quit();
        }
        if(Input.GetKeyDown(KeyCode.Return)){
            Play();
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            About();
        }
    }
}
