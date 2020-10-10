﻿using System.Collections;
using System.Collections.Generic;
using System.Runtime.Hosting;
using UnityEngine;

public class AudioController_4 : MonoBehaviour
{
    public const string audioName = "Title_Music.wav";

    [Header("Audio Stuff")]
    public AudioSource audioSource;
    public AudioClip audioClip;
    public string soundPath;

    private void Awake()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        soundPath = "file://" + Application.streamingAssetsPath + "/Sound/";
        StartCoroutine(LoadAudio());
    }

    private IEnumerator LoadAudio()
    {
        WWW request = GetAudioFromFile(soundPath, audioName);
        yield return request;

        audioClip = request.GetAudioClip();
        audioClip.name = audioName;

        PlayAudioFile();
    }

    private void PlayAudioFile()
    {
        audioSource.clip = audioClip;
        audioSource.Play();
        audioSource.loop = true;
    }

    private WWW GetAudioFromFile(string path, string filename)
    {
        string audioToLoad = string.Format(path + "{0}", filename);
        WWW request = new WWW(audioToLoad);
        return request;
    }
}
