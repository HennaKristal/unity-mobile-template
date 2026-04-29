using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{
    [SerializeField] private AudioSource audioSource;
    // [SerializeField] private AudioClip clickSound;

    public void PlayClickSound()
    {
        // audioSource.PlayOneShot(clickSound);
    }
}
