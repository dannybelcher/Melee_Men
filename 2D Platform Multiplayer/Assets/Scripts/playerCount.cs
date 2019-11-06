using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Defines the <see cref="playerCount" />
/// </summary>
public class playerCount : MonoBehaviour
{
    /// <summary>
    /// Defines the one
    /// </summary>
    public Button one;

    /// <summary>
    /// Defines the two
    /// </summary>
    public Button two;

    /// <summary>
    /// Defines the three
    /// </summary>
    public Button three;

    /// <summary>
    /// Defines the four
    /// </summary>
    public Button four;

    // Start is called before the first frame update
    /// <summary>
    /// The Start
    /// </summary>
    internal void Start()
    {
        one.onClick.AddListener(One);
        two.onClick.AddListener(Two);
        three.onClick.AddListener(Three);
        four.onClick.AddListener(Four);
    }

    /// <summary>
    /// The One
    /// </summary>
    internal void One()
    {
        playerValues.playerCount = 1;
    }

    /// <summary>
    /// The Two
    /// </summary>
    internal void Two()
    {
        playerValues.playerCount = 2;
    }

    /// <summary>
    /// The Three
    /// </summary>
    internal void Three()
    {
        playerValues.playerCount = 3;
    }

    /// <summary>
    /// The Four
    /// </summary>
    internal void Four()
    {
        playerValues.playerCount = 4;
    }
}
