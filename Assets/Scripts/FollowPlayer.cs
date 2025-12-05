using System.Collections;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Public variable to store a reference to the player game object
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -14);
    //Camera swap variables
    private bool cameraSwapInput;
    int cameraState = 0;
    public KeyCode swapKey;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    //LateUpdate is called after Update each frame
    void LateUpdate()
    {
        //offset the camera position relative to the player position

        transform.position = player.transform.position + offset;
        //Gets if key is pressed
        if (cameraSwapInput = Input.GetKeyDown(swapKey))
        {
            switch (cameraState)
            {
                case 0:
                    //front view
                    offset = new Vector3(0, 1.5f, 4.5f);
                    cameraState++;
                    break;
                case 1:
                    //back view
                    offset = new Vector3(0, 5, -14);
                    cameraState--;
                    break;
            }
        }
        
            
    }
}
