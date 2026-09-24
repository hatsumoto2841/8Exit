using UnityEngine;

public class ImageChange : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;

    private int oldNumber = -1;

    void Update()
    {
        int currentNumber = Warpnoihen.kazu.number;

        if (currentNumber != oldNumber)
        {
            oldNumber = currentNumber;

            if (currentNumber >= 0 && currentNumber < sprites.Length)
            {
                spriteRenderer.sprite = sprites[currentNumber];
            }
        }
    }
}
