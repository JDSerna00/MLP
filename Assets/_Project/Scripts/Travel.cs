using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Travel : MonoBehaviour
{
    public Transform[] positions; 
    public float moveSpeed = 2f;  
    private int currentPositionIndex = 0;  
    private bool isMoving = false;  

    private Transform player;
    private FirstPersonController playerMovement;

    void Update()
    {    
        if (isMoving && currentPositionIndex < positions.Length)
        {
            MoveObject();
        }
    }

    void MoveObject()
    {

        transform.position = Vector3.MoveTowards(transform.position, positions[currentPositionIndex].position, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, positions[currentPositionIndex].position) < 0.1f)
        {
            currentPositionIndex++;

            if (currentPositionIndex >= positions.Length)
            {
                isMoving = false;
                if (player != null)
                {
                    player.SetParent(null);  // Detach player when the object reaches the last position
                    playerMovement.enabled = true;
                }
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player = other.transform;
            player.SetParent(transform);
            isMoving = true;
            playerMovement = other.GetComponent<FirstPersonController>();
            other.GetComponent<FirstPersonController>().enabled = false;
        }
    }
}
