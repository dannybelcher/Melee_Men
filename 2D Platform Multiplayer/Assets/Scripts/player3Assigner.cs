using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Defines the <see cref="player3Assigner" />
/// </summary>
public class player3Assigner : MonoBehaviour
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
        PlayerValues.P3knight = true;
        PlayerValues.P3archer = false;
        PlayerValues.P3viking = false;
        PlayerValues.P3wizard = false;
    }

    /// <summary>
    /// The archer
    /// </summary>
    public void archer()
    {
        PlayerValues.P3knight = false;
        PlayerValues.P3archer = true;
        PlayerValues.P3viking = false;
        PlayerValues.P3wizard = false;
    }

    /// <summary>
    /// The viking
    /// </summary>
    public void viking()
    {
        PlayerValues.P3knight = false;
        PlayerValues.P3archer = false;
        PlayerValues.P3viking = true;
        PlayerValues.P3wizard = false;
    }

    /// <summary>
    /// The wizard
    /// </summary>
    public void wizard()
    {
        PlayerValues.P3knight = false;
        PlayerValues.P3archer = false;
        PlayerValues.P3viking = false;
        PlayerValues.P3wizard = true;
    }
}
