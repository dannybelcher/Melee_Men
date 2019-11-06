using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Defines the <see cref="MainMenu" />
/// </summary>
public class MainMenu : MonoBehaviour
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
    /// The Update
    /// </summary>
    internal void Update()
    {
        if (Input.GetButtonDown("P1_Start")
            || Input.GetKeyDown(KeyCode.Return)
            || Input.GetKeyDown("space")
            || Input.GetMouseButton(0))
        {
            SceneManager.LoadScene("MapSelector");
        }
    }
}
