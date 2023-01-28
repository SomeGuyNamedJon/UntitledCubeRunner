using UnityEngine;
using UnityEngine.SceneManagement;

public class aboutMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Return(){
        SceneManager.LoadScene("Menu");
    }

    public void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            Return();
        }
    }
}
