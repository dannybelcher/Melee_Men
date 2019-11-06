using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Defines the <see cref="player2Assigner" />
/// </summary>
public class player2Assigner : MonoBehaviour
{
    /// <summary>
    /// Defines the KnightButton
    /// </summary>
    public Button KnightButton;

    /// <summary>
    /// Defines the ArcherButton
    /// </summary>
    public Button ArcherButton;

    /// <summary>
    /// Defines the WizardButton
    /// </summary>
    public Button WizardButton;

    /// <summary>
    /// Defines the VikingButton
    /// </summary>
    public Button VikingButton;

    /// <summary>
    /// The Start
    /// </summary>
    internal void Start()
    {

        KnightButton.onClick.AddListener(knight);
        ArcherButton.onClick.AddListener(archer);
        WizardButton.onClick.AddListener(wizard);
        VikingButton.onClick.AddListener(viking);
    }

    /// <summary>
    /// The knight
    /// </summary>
    public void knight()
    {
        playerValues.P2knight = true;
        playerValues.P2archer = false;
        playerValues.P2viking = false;
        playerValues.P2wizard = false;
    }

    /// <summary>
    /// The archer
    /// </summary>
    public void archer()
    {
        playerValues.P2knight = false;
        playerValues.P2archer = true;
        playerValues.P2viking = false;
        playerValues.P2wizard = false;
    }

    /// <summary>
    /// The viking
    /// </summary>
    public void viking()
    {
        playerValues.P2knight = false;
        playerValues.P2archer = false;
        playerValues.P2viking = true;
        playerValues.P2wizard = false;
    }

    /// <summary>
    /// The wizard
    /// </summary>
    public void wizard()
    {
        playerValues.P2knight = false;
        playerValues.P2archer = false;
        playerValues.P2viking = false;
        playerValues.P2wizard = true;
    }
}
