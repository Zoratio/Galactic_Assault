using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlaylist : MonoBehaviour
{
    [SerializeField] AudioClip[] musicClips;

    AudioSource audioSource;


    void Awake()
    {
        SetUpSingleton();
        audioSource = GetComponent<AudioSource>();
    }

    private void SetUpSingleton()
    {
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(musicClips[Random.Range(0, musicClips.Length-1)]);
        }
    }
}
