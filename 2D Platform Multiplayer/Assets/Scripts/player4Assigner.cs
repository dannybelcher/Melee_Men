using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Defines the <see cref="player4Assigner" />
/// </summary>
public class player4Assigner : MonoBehaviour
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
        PlayerValues.P4knight = true;
        PlayerValues.P4archer = false;
        PlayerValues.P4viking = false;
        PlayerValues.P4wizard = false;
    }

    /// <summary>
    /// The archer
    /// </summary>
    public void archer()
    {
        PlayerValues.P4knight = false;
        PlayerValues.P4archer = true;
        PlayerValues.P4viking = false;
        PlayerValues.P4wizard = false;
    }

    /// <summary>
    /// The viking
    /// </summary>
    public void viking()
    {
        PlayerValues.P4knight = false;
        PlayerValues.P4archer = false;
        PlayerValues.P4viking = true;
        PlayerValues.P4wizard = false;
    }

    /// <summary>
    /// The wizard
    /// </summary>
    public void wizard()
    {
        PlayerValues.P4knight = false;
        PlayerValues.P4archer = false;
        PlayerValues.P4viking = false;
        PlayerValues.P4wizard = true;
    }
}
