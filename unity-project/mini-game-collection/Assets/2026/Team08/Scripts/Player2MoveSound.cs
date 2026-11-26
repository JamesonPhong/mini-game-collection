using UnityEngine;

public class Player2MovementSound : MonoBehaviour
{
    public KeyCode movementKey = KeyCode.D;
    public Player2Jump playerJump;

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