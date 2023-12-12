using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DirectionToMove
{
    X,
    Y,
    Z,
}

public class MovingPlatform : MonoBehaviour
{
    [Range(0.0f, 10.0f)]
    public float distanceToTravel;

    [Range(-10.0f, 10.0f)]
    public float speed;

    private Vector3 startPos;
    public DirectionToMove direction;
    private Vector3 directionVector;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        switch (direction)
        {
            case DirectionToMove.X:
                directionVector = Vector3.right;
                break;
            case DirectionToMove.Y:
                directionVector = Vector3.up;
                break;
            case DirectionToMove.Z:
                directionVector = Vector3.forward;
                break;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 curPos = startPos + directionVector * Mathf.PingPong(Time.time * speed, distanceToTravel);
        transform.position = curPos;
    }
}
