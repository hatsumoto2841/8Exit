using UnityEngine;

public class PositionChange : MonoBehaviour
{
    public Vector3 changedPosition;

    private Vector3 defaultPosition;

    void Start()
    {
        defaultPosition = transform.position;
    }

    void Update()
    {
        if (Warpnoihen.kazu.ihen == 3)
        {
            transform.position = changedPosition;
        }
        else
        {
            transform.position = defaultPosition;
        }
    }
}
