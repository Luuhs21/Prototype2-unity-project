using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnManager : MonoBehaviour
{
    //variables
    public GameObject[] animalPrefebs;
    public InputAction spawnAction;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;

    //setting invoke repeting timing
    public float startDelay = 2;
    public float spawnInterval = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //invoking the method
        InvokeRepeating("spawningAnimals", startDelay, spawnInterval);


        spawnAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //methods
    public void spawningAnimals()
    {
        int animalIndex = Random.Range(0, animalPrefebs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefebs[animalIndex], spawnPos, animalPrefebs[animalIndex].transform.rotation);

    }
}
