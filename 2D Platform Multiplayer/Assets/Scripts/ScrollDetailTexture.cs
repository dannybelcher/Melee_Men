using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Defines the <see cref="ScrollDetailTexture" />
/// </summary>
[RequireComponent(typeof(Image))]
public class ScrollDetailTexture : MonoBehaviour
{
    /// <summary>
    /// Defines the uniqueMaterial
    /// </summary>
    public bool uniqueMaterial = false;

    /// <summary>
    /// Defines the scrollPerSecond
    /// </summary>
    public Vector2 scrollPerSecond = Vector2.zero;

    /// <summary>
    /// Defines the m_Matrix
    /// </summary>
    internal Matrix4x4 m_Matrix;

    /// <summary>
    /// Defines the mCopy
    /// </summary>
    internal Material mCopy;

    /// <summary>
    /// Defines the mOriginal
    /// </summary>
    internal Material mOriginal;

    /// <summary>
    /// Defines the mSprite
    /// </summary>
    internal Image mSprite;

    /// <summary>
    /// Defines the m_Mat
    /// </summary>
    internal Material m_Mat;

    /// <summary>
    /// The OnEnable
    /// </summary>
    internal void OnEnable()
    {
        mSprite = GetComponent<Image>();
        mOriginal = mSprite.material;

        if (uniqueMaterial && mSprite.material != null)
        {
            mCopy = new Material(mOriginal);
            mCopy.name = "Copy of " + mOriginal.name;
            mCopy.hideFlags = HideFlags.DontSave;
            mSprite.material = mCopy;
        }
    }

    /// <summary>
    /// The OnDisable
    /// </summary>
    internal void OnDisable()
    {
        if (mCopy != null)
        {
            mSprite.material = mOriginal;
            if (Application.isEditor)
                UnityEngine.Object.DestroyImmediate(mCopy);
            else
                UnityEngine.Object.Destroy(mCopy);
            mCopy = null;
        }
        mOriginal = null;
    }

    /// <summary>
    /// The Update
    /// </summary>
    internal void Update()
    {
        Material mat = (mCopy != null) ? mCopy : mOriginal;

        if (mat != null)
        {
            Texture tex = mat.GetTexture("_DetailTex");

            if (tex != null)
            {
                mat.SetTextureOffset("_DetailTex", scrollPerSecond * Time.time);

                // TODO: It would be better to add support for MaterialBlocks on UIRenderer,
                // because currently only one Update() function's matrix can be active at a time.
                // With material block properties, the batching would be correctly broken up instead,
                // and would work with multiple widgets using this detail shader.
            }
        }
    }
}
