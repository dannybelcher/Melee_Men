using UnityEngine;

/// <summary>
/// Defines the <see cref="ChangeColor" />
/// </summary>
public class ChangeColor : MonoBehaviour
{
    /// <summary>
    /// Defines the playerNumber
    /// </summary>
    public int playerNumber;

    /// <summary>
    /// Defines the playerID1
    /// </summary>
    public GameObject playerID1;

    /// <summary>
    /// Defines the playerID2
    /// </summary>
    public GameObject playerID2;

    /// <summary>
    /// Defines the playerID3
    /// </summary>
    public GameObject playerID3;

    /// <summary>
    /// The Start
    /// </summary>
    private void Start()
    {
        ChangeColorID(playerNumber);
    }

    /// <summary>
    /// The Update
    /// </summary>
    private void Update()
    {
    }

    /// <summary>
    /// The ChangeColorID
    /// </summary>
    /// <param name="playerNumber">The playerNumber<see cref="int"/></param>
    internal void ChangeColorID(int playerNumber)
    {
        Renderer playerID1Render = playerID1.GetComponent<Renderer>();
        Renderer playerID2Render = playerID2.GetComponent<Renderer>();
        Renderer playerID3Render = playerID3.GetComponent<Renderer>();
        switch (playerNumber)
        {
            case 1:
                playerID1Render.material.color = Color.red;
                playerID2Render.material.color = Color.red;
                playerID3Render.material.color = Color.red;
                break;
            case 2:
                playerID1Render.material.color = Color.blue;
                playerID2Render.material.color = Color.blue;
                playerID3Render.material.color = Color.blue;
                break;
            case 3:
                playerID1Render.material.color = Color.green;
                playerID2Render.material.color = Color.green;
                playerID3Render.material.color = Color.green;
                break;
            case 4:
                playerID1Render.material.color = Color.yellow;
                playerID2Render.material.color = Color.yellow;
                playerID3Render.material.color = Color.yellow;
                break;

        }
    }
}
