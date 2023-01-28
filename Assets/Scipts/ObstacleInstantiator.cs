using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleInstantiator : MonoBehaviour
{
    public GameObject[] obstaclesEasy;
    public GameObject[] obstaclesMedium;
    public GameObject[] obstaclesHard;
    public GameObject[] obstaclesPowerUp;
    public GameManager manager;

    //public GameObject test;

    private int index;
    private float powerUpSpawn;

    private float spawnRate = 7f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn(){
        while(!manager.playerDead){
            powerUpSpawn = Random.Range(-1f, GameManager.powerUpFrequency);
            if(powerUpSpawn > 1){
                index = Random.Range(0,(obstaclesPowerUp.Length - 1));
                Instantiate(obstaclesPowerUp[index], transform);
            }else{
                if(GameManager.levelCnt > 4){
                    index = Random.Range(0,(obstaclesEasy.Length - 1));
                    Instantiate(obstaclesEasy[index], transform);
                }
                if(GameManager.levelCnt > 9){
                    index = Random.Range(0,(obstaclesMedium.Length - 1));
                    Instantiate(obstaclesMedium[index], transform);
                }
                if(GameManager.levelCnt > 14){
                    index = Random.Range(0,(obstaclesHard.Length - 1));
                    Instantiate(obstaclesHard[index], transform);
                }
            }
            //Instantiate(test, transform);
            yield return new WaitForSeconds(spawnRate/GameManager.obstacleSpawnModifier);
        }
    }
}
