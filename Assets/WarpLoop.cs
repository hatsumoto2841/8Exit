using UnityEngine;
using static Warpnoihen;

public class WarpLoop : MonoBehaviour
{
    public Transform kitaku;
    public Transform Goal2;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            if (kazu.number >= 8)
            {
                other.transform.position = Goal2.position;
                return;
            }
            if (kazu.ihen == 1)
            {
                kazu.number = 0;
            }
            else if (kazu.ihen == 2)
            {
                kazu.number++;
            }
            else if (kazu.ihen == 3)
            {
                kazu.number++;
            }
            if(kazu.number <= 9)
            {
                    other.transform.position = kitaku.position;
            }
            kazu.ihen = Random.Range(1, 4);
        }
    }
}
