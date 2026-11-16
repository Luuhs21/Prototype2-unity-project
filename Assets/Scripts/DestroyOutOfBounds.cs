using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //variables
    private float topBound = 30;
    private float lowerBound = -10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        destroySteak();
    }

    public void destroySteak()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
