using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public Vector3 offset = new Vector3(0f, 5f, -10f);

    private void LateUpdate()
    {
        if (target == null)
        {
            Debug.LogWarning("CameraFollow: target ‚ªİ’è‚³‚ê‚Ä‚¢‚Ü‚¹‚ñB");
            return;
        }

        // ‚»‚Ì‚Ü‚Ü‘¦’Ç]
        transform.position = target.position + offset;
    }
}
