using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private variables
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    public int playerType; //1 for player 1, 2 for player 2
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get the horizontal input from unity input manager
        horizontalInput = Input.GetAxis("Horizontal" + playerType);
        forwardInput = Input.GetAxis("Vertical" + playerType);
        //move vehicle forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //rotate the vehicle based on horizontal input rather than translating it
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
