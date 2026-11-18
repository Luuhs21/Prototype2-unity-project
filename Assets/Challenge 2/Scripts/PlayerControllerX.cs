using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public InputAction fireAction;
    public bool dogIsCalled = true;

    // Start is called before the first frame update
    void Start()
    {
        fireAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
       SendDog();
    }

    //methods
    void SendDog()
    {
         // On spacebar press, send dog and verify if the dog was called to stop the "spam"
        if (fireAction.triggered && dogIsCalled == true)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            dogIsCalled = false;
            Invoke("DogIsCalled", 1.0f);
        }
    }
    void DogIsCalled()
    {
        dogIsCalled = true;
    }
}
