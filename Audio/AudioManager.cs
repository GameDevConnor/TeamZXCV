using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;

    public static AudioManager instance;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }   

        DontDestroyOnLoad(gameObject);

        foreach(Sound sound in sounds)
        {
            sound.source = gameObject.AddComponent<AudioSource>();
            sound.source.clip = sound.clip;
            sound.source.volume = sound.volume;
            sound.source.pitch = sound.pitch;
            sound.source.loop = sound.loop;
        }

    }

    private void Start()
    {
     //   Play("Music");
    }

    public void Play(String name)
    {
        Sound sound = Array.Find(sounds, sound => sound.name == name);
        if (sound == null) // Tries to reference a sound name that doesn’t exist
        {
            Debug.LogWarning("Sound " + name + " wasn’t found");
            return; // In order to avoid a NullReferenceException
        }

        sound.source.Play();
    }

    public void StopAllExcept(String name)
    {
        foreach (Sound sound in sounds)
        {
            if (Equals(name, sound.name) == false)
            {
                sound.source.Stop();
            }
        }
    }

}
