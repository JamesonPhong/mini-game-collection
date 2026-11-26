using UnityEngine;

public class Player1MovementSound : MonoBehaviour
{
    public KeyCode movementKey = KeyCode.RightArrow;
    public Player1Jump playerJump;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKey(movementKey) && !playerJump.hasJumped)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}