using UnityEngine;

public class Warpnoihen : MonoBehaviour
{
    public Transform destination;
    public Transform last;
    public static class kazu
    {
        public static int number = 0;
        public static int ihen = 1;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (kazu.number >= 8)
            {
                other.transform.position = last.position;
                return;
            }
            if (kazu.ihen == 1)
            {
                kazu.number++;
            }
            else if(kazu.ihen == 2)
            {
                kazu.number = 0;
            }
            else if(kazu.ihen == 3)
            {
                kazu.number = 0;
            }
            if (kazu.number <= 9)
            {
                other.transform.position = destination.position;
            }
            kazu.ihen = Random.Range(1, 4);
            Debug.Log(kazu.number);
            Debug.Log(kazu.ihen);
        }
    }
}
