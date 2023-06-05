using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new(0, 5f, -7f);
    private Vector3 offset2 = new(0, 2f, 0.7f);
    private int currentOffset = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate() // LateUpdate is called after the Update method, so now the camera's position is always updated after the player's position, solving the jittery problem.
    {
        if (currentOffset == 0)
        {
            transform.position = player.transform.position + offset;
            if (Input.GetKeyDown(KeyCode.LeftShift)) 
            {
                currentOffset = 1;
            }
        } else if (currentOffset == 1)
        {
            transform.position = player.transform.position + offset2;
            transform.rotation = player.transform.rotation;
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                currentOffset = 0;
                transform.rotation = Quaternion.Euler(20f, 0f, 0.09f);
                Debug.Log("Here");
            }
        }
    }
}
