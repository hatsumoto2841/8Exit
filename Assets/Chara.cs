using UnityEngine;
using UnityEngine.InputSystem;

public class Chara : MonoBehaviour
{
    [Header("足音")]
    public AudioClip footstepClip;
    public float footstepInterval = 0.4f;
    private AudioSource audioSource;

    private float footstepTimer;
    public float moveSpeed = 5f;

    private Animator animator;
    public float interval = 0.01f;
    private float timer;
    private SpriteRenderer sr;

    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float move = 0f;

        if (Keyboard.current.aKey.isPressed)
        {
            move = -1.1f;
        }

        if (Keyboard.current.dKey.isPressed)
        {
            move = 1.1f;
        }

        if(Keyboard.current.spaceKey.isPressed)
        {
            timer += Time.deltaTime;

            if (timer >= interval)
            {
                sr.flipX = !sr.flipX;
                timer = 0f;
            }
        }
        else
        {
            timer = 0f;
        }

        // 移動
        transform.Translate(Vector3.right * move * moveSpeed * Time.deltaTime);

        // アニメーション
        animator.SetBool("Ismoving", move != 0);

        // 向き変更
        if (move > 0)
        {
            transform.localScale = new Vector3(3, 3, 1);
        }
        else if (move < 0)
        {
            transform.localScale = new Vector3(-3, 3, 1);
        }

        if (move != 0)
        {
            footstepTimer -= Time.deltaTime;

            if (footstepTimer <= 0)
            {
                audioSource.PlayOneShot(footstepClip);
                footstepTimer = footstepInterval;
            }
        }
        else
        {
            footstepTimer = 0;
        }
    }
}