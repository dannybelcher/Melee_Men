using UnityEngine;

/// <summary>
/// Defines the <see cref="spriteFader" />
/// </summary>
public class spriteFader : MonoBehaviour
{
    /// <summary>
    /// Defines the fadeSpeed
    /// </summary>
    public float fadeSpeed = 1f;

    /// <summary>
    /// Defines the fadeTime
    /// </summary>
    public float fadeTime = 1f;

    /// <summary>
    /// Defines the fadeIn
    /// </summary>
    public bool fadeIn = true;

    /// <summary>
    /// Defines the text
    /// </summary>
    public SpriteRenderer text;

    // Update is called once per frame
    /// <summary>
    /// The Update
    /// </summary>
    internal void Update()
    {


        if (fadeIn)
        {
            //float Fade = Mathf.SmoothDamp(0f, 1f, fadeSpeed, fadeTime);
            //text.color = new Color(1f, 1f, 1f, Fade);
        }

        if (!fadeIn)
        {
            //float Fade = Mathf.SmoothDamp(1f, 0f, fadeSpeed, fadeTime);
            //text.color = new Color(1f, 1f, 1f, Fade);
        }
    }
}
