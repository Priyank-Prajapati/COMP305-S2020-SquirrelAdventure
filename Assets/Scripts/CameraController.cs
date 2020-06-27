using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // privste inspector variable
    [SerializeField] private Transform player;
    [SerializeField] private Transform moveThreshold;

    void Update()
    {
        if (player.position.x > moveThreshold.position.x)
        {
            //camera follows the player
            transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(
            new Vector2(moveThreshold.position.x, moveThreshold.position.y + 10),
            new Vector2(moveThreshold.position.x, moveThreshold.position.y - 10));
    }
}
