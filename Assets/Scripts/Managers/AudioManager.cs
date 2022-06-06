using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{
    [SerializeField] AudioClip[] audioClips;
    private AudioSource source;

    public override void Awake()
    {
        base.Awake();
        if(source == null)
            source = GetComponent<AudioSource>();
    }
    public void PlaySoundtrack()
    {
        
        source.clip = audioClips[0];
        source.loop = true;
        source.PlayOneShot(source.clip);
    }
    public void StopSoundtrack()
    {
        source.clip = audioClips[0];
        source.Stop();
    }
    public void TapUIButtons()
    {
        source.clip = audioClips[1];
        source.loop = false;
        source.PlayOneShot(source.clip);
    }
    public void PlayRaceMusic()
    {
        StopSoundtrack();
        source.clip = audioClips[2];
        source.loop = true;
        source.PlayOneShot(source.clip);
    }
    public void StopRaceMusic()
    {
        source.clip = audioClips[2];
        source.Stop();
    }
    public void WinRace()
    {
        StopRaceMusic();
        source.clip = audioClips[5];
        source.loop = false;
        source.PlayOneShot(source.clip);
    }
    public void LoseRace()
    {
        StopRaceMusic();
        source.clip = audioClips[6];
        source.loop = false;
        source.PlayOneShot(source.clip);
    }
    public void TakeCoin()
    {
        source.clip = audioClips[3];
        source.loop = false;
        source.PlayOneShot(source.clip);
    }
    public void TakeDamage()
    {
        source.clip = audioClips[4];
        source.loop = false;
        source.PlayOneShot(source.clip);
    }
    public void CorrectAnswer()
    {
        source.clip = audioClips[7];
        source.loop = false;
        source.PlayOneShot(source.clip);
    }
    public void IncorrectAnswer()
    {
        source.clip = audioClips[8];
        source.loop = false;
        source.PlayOneShot(source.clip);
    }
    public void QuizPlayResults()
    {
        source.clip = audioClips[9];
        source.loop = false;
        source.PlayOneShot(source.clip);
    }



}
