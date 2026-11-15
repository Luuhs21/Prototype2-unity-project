using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    //variables
    public InputAction moveAction;

    public Vector2 moveInput;
    //player speed of movement
    public float speed = 10.0f;
    public float xRange = 10.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        playerMoveLeftRight();
    }

    //methods
    public void playerMoveLeftRight()
    {
        //get the arrow Iam pressing
        moveInput = moveAction.ReadValue<Vector2>();
        //player movement
        transform.Translate(Vector3.right * moveInput.x * Time.deltaTime * speed);
        //interrupt player to go beyond the screen left side
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

           //interrupt player to go beyond the screen right side
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

    }
}
