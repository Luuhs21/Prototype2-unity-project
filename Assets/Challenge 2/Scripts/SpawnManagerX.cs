using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    //private float spawnInterval = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
        //created for the challenge
        Invoke("SpawnRandomBall", startDelay);
        
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {

        //get the ball vetor and call random collors 
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);

        //created for the challenge
        float randomInterval = Random.Range(3f, 6f);
        Invoke("SpawnRandomBall", randomInterval);

        //monitoring the random interval generate
        //Debug.Log(randomInterval);
        
    }

}
