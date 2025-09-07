using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * movementSpeed * Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        movementSpeed = -movementSpeed;
    }
}
