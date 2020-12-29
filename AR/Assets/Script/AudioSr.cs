using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSr : MonoBehaviour
{
    [SerializeField]
    private AudioClip ButtonSound;
    private AudioSource AuSr;


    // Start is called before the first frame update
    void Start()
    {
        AuSr = GetComponent<AudioSource>();
    }

    public void PlayButtonSound()
    {
        AuSr.PlayOneShot(ButtonSound);
    }
}
