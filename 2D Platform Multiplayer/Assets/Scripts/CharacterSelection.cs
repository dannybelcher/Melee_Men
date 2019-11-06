using UnityEngine;

/// <summary>
/// Defines the <see cref="CharacterSelection" />
/// </summary>
public class CharacterSelection : MonoBehaviour
{
    /// <summary>
    /// Defines the player
    /// </summary>
    public string player;

    /// <summary>
    /// Defines the wizardMarker, archerMarker, knightMarker, vikingMarker
    /// </summary>
    public GameObject wizardMarker,
                      archerMarker,
                      knightMarker,
                      vikingMarker;

    /// <summary>
    /// Defines the charMarkers
    /// </summary>
    public GameObject[] charMarkers = new GameObject[4];

    // Start is called before the first frame update
    /// <summary>
    /// The Start
    /// </summary>
    internal void Start()
    {
        charMarkers[0] = wizardMarker;
        charMarkers[1] = archerMarker;
        charMarkers[2] = knightMarker;
        charMarkers[3] = vikingMarker;
    }

    // Update is called once per frame
    /// <summary>
    /// The Update
    /// </summary>
    internal void Update()
    {
        disableMarkers();
        if (player.Equals("player1"))
        {
            if (playerValues.P1wizard)
            {
                wizardMarker.SetActive(true);
            }
            else if (playerValues.P1archer)
            {
                archerMarker.SetActive(true);
            }
            else if (playerValues.P1knight)
            {
                knightMarker.SetActive(true);
            }
            else if (playerValues.P1viking)
            {
                vikingMarker.SetActive(true);
            }
        }
        else if (player.Equals("player2"))
        {
            if (playerValues.P2wizard)
            {
                wizardMarker.SetActive(true);
            }
            else if (playerValues.P2archer)
            {
                archerMarker.SetActive(true);
            }
            else if (playerValues.P2knight)
            {
                knightMarker.SetActive(true);
            }
            else if (playerValues.P2viking)
            {
                vikingMarker.SetActive(true);
            }
        } 
        else if (player.Equals("player3"))
        {
            if (playerValues.P3wizard)
            {
                wizardMarker.SetActive(true);
            }
            else if (playerValues.P3archer)
            {
                archerMarker.SetActive(true);
            }
            else if (playerValues.P3knight)
            {
                knightMarker.SetActive(true);
            }
            else if (playerValues.P3viking)
            {
                vikingMarker.SetActive(true);
            }
        }
        else if (player.Equals("player4"))
        {
            if (playerValues.P4wizard)
            {
                wizardMarker.SetActive(true);
            }
            else if (playerValues.P4archer)
            {
                archerMarker.SetActive(true);
            }
            else if (playerValues.P4knight)
            {
                knightMarker.SetActive(true);
            }
            else if (playerValues.P4viking)
            {
                vikingMarker.SetActive(true);
            }
        }
    }

    /// <summary>
    /// The disableMarkers
    /// </summary>
    internal void disableMarkers()
    {
        for (int i = 0; i < 4; i++)
        {
            charMarkers[i].SetActive(false);
        }
    }
}
