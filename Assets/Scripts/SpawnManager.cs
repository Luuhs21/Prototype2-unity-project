using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnManager : MonoBehaviour
{
    //variables
    public GameObject[] animalPrefebs;
    public InputAction spawnAction;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        spawningAnimals();
    }

    public void spawningAnimals()
    {
        if (spawnAction.triggered)
        {
            int animalIndex = Random.Range(0, animalPrefebs.Length);
            Vector3 spawnPos =  new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Instantiate(animalPrefebs[animalIndex], spawnPos, animalPrefebs[animalIndex].transform.rotation);
        }
    }
}
