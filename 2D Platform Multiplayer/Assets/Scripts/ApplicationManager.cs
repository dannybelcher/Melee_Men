using UnityEngine;

/// <summary>
/// Defines the <see cref="ApplicationManager" />
/// </summary>
public class ApplicationManager : MonoBehaviour
{
    /// <summary>
    /// The Quit
    /// </summary>
    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
		Application.Quit();
    }
}
