using UnityEngine;
using UnityEngine.UI;

public class countLevelUp : MonoBehaviour
{
    public Text LevelCounter;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("LevelCnt = " + GameManager.levelCnt);
        LevelCounter.text = (GameManager.levelCnt).ToString("Level 0");
    }
}
