using UnityEngine;

public class addihenone : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Warpnoihen.kazu.ihen == 2)
        {
            transform.localScale = new Vector3(0.5f, -0.5f, 1);
            transform.position = new Vector3(38, 0.5f, 0);
        }
        else
        {
            transform.localScale = new Vector3(0.5f,0.5f,1);
            transform.position = new Vector3(38, 0.5f, 0);
        }
    }
}
