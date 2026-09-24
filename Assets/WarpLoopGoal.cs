using UnityEngine;

public class WarpLoopGoal : MonoBehaviour
{
    public Transform Loopi;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = Loopi.position;
        }
    }
}
