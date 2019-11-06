using UnityEngine;

/// <summary>
/// Defines the <see cref="musicContinuation" />
/// </summary>
public class MusicContinuation : MonoBehaviour
{
    /// <summary>
    /// Defines the _audioSource
    /// </summary>
    private AudioSource _audioSource;

    /// <summary>
    /// The Awake
    /// </summary>
    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    /// <summary>
    /// The PlayMusic
    /// </summary>
    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    /// <summary>
    /// The StopMusic
    /// </summary>
    public void StopMusic()
    {
        _audioSource.Stop();
    }
}
