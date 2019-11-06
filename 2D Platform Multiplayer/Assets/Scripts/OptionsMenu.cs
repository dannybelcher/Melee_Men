using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Defines the <see cref="OptionsMenu" />
/// </summary>
public class OptionsMenu : MonoBehaviour
{
    // Start is called before the first frame update
    /// <summary>
    /// The Start
    /// </summary>
    internal void Start()
    {
    }

    // Update is called once per frame
    /// <summary>
    /// The RestartLevel
    /// </summary>
    public void RestartLevel()
    {
        Scene sc = SceneManager.GetActiveScene();
        SceneManager.SetActiveScene(sc);
    }
}
