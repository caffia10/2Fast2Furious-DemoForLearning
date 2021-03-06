﻿using Assets.Source.DesignPattern;
using UnityEngine;

public class AudioFx : SingletonMonoBehaviour<AudioFx>
{
    public AudioClip[] Fxs;
    private AudioSource audioSourceComp;

    private void Start()
    {
        audioSourceComp = GetComponent<AudioSource>();
    }

    public void FXSoundCarCrash()
    {
        PlayAudioClipByIndex(0);
    }

    public void FXSoundGameOver()
    {
        PlayAudioClipByIndex(1);
    }

    private void PlayAudioClipByIndex(int index)
    {
        audioSourceComp.clip = Fxs[index];
        audioSourceComp.Play();
    }
}
