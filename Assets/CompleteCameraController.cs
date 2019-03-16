using UnityEngine;
using System.Collections;

public class CompleteCameraController : MonoBehaviour
{
    public float catchupSpeed = 10f;
    public GameObject player;       //Public variable to store a reference to the player game object


    private Vector3 offset;         //Private variable to store the offset distance between the player and camera

    // Use this for initialization
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        //offset = transform.position - player.transform.position;

        transform.position = new Vector3 (player.transform.position.x , player.transform.position.y , -10) ;
    }

    // LateUpdate is called after Update each frame
    void FixedUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.

        //transform.position = player.transform.position + offset;

        CalculateOffset();
    }

    void CalculateOffset()
    {
        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;

        x = x * 0.9f + player.transform.position.x * 0.1f;
        y = y * 0.9f + player.transform.position.y * 0.1f;

        transform.position = new Vector3(x, y, z);

    }
}