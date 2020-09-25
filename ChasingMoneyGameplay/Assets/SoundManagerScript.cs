using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip oldmanHitSound, coinpickupSound, gameoverSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        oldmanHitSound = Resources.Load<AudioClip>("hitsound");
        coinpickupSound = Resources.Load<AudioClip>("CoinSounds");
        gameoverSound = Resources.Load<AudioClip>("gameover");

        audioSrc = GetComponent<AudioSource> ();
    }

    public static void PlaySound(string clip)
    {
        switch (clip) { 
            case "hitsound" :
                audioSrc.PlayOneShot(oldmanHitSound);
                break;
            case "CoinSounds" :
                audioSrc.PlayOneShot(coinpickupSound);
                break;
            case "gameover" :
                audioSrc.PlayOneShot(gameoverSound);
                break;
                 
        }
    }
}
