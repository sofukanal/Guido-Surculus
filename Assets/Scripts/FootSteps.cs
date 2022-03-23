using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour
{
    CharacterController cc;

    [SerializeField]
    AudioSource audioSource;

    private void Start()
    {
        cc = GetComponent<CharacterController>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        // Plays footstep sound if player is grounded and moving 
        if (cc.isGrounded == true && cc.velocity.magnitude > 2f && audioSource.isPlaying == false)
        {
            // Changes the Volume and Pitch of the soound randomly to make it sound more realistic
            audioSource.volume = Random.Range(0.3f, 0.4f);
            audioSource.pitch = Random.Range(0.8f, 1.1f);
            audioSource.Play();
        }
    }
}
