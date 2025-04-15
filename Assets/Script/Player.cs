using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // ←：-1、→：+1
        transform.Translate(Vector3.right * horizontal * speed * Time.deltaTime);
    }
}
