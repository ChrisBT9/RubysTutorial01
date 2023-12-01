using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedCollectible : MonoBehaviour
//Code made by Michael SpeedBuff
{
    public AudioClip collectedClip;

    AudioSource audioSource;

    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if(controller != null)
        {
            if (controller.speed < 4.0f)
            {
                controller.speed = 6.0f;
                Destroy(gameObject);
                controller.PlaySound(collectedClip);
            }
        }
    }

    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

}

