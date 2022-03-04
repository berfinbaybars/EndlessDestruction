using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip ExplosionSoundObj;
    public static AudioClip ExplosionSound;

    private void Start()
    {
        ExplosionSound = ExplosionSoundObj;
    }
    public static void EnemyExplodedSound()
    {
        if (PlayerPrefs.GetInt("Sound") != 1) return;
        GameObject soundGameObject = new GameObject("Sound");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot(ExplosionSound, 0.05f);
    }
}
