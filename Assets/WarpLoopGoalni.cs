using UnityEngine;

public class WarpLoopGoalni : MonoBehaviour
{
    public Transform Loopii;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = Loopii.position;
        }
    }
}
