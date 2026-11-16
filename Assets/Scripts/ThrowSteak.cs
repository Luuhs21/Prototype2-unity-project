using UnityEngine;

public class ThrowSteak : MonoBehaviour
{
    //variables
    public float speed = 20.0f;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movingFoward();
    }

    //methods 

    public void movingFoward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
