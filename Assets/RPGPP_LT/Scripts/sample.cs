using UnityEngine;

public class sample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name + " collided with me");
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Audran"))
        {
            Debug.Log(other.gameObject.name + " touched me");
        }
    }
}
