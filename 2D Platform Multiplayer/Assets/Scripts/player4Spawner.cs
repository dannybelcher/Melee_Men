using UnityEngine;

/// <summary>
/// Defines the <see cref="player4Spawner" />
/// </summary>
public class player4Spawner : MonoBehaviour
{
    /// <summary>
    /// Defines the spawnPoint
    /// </summary>
    public Transform spawnPoint;

    /// <summary>
    /// Defines the knight
    /// </summary>
    public GameObject knight;

    /// <summary>
    /// Defines the archer
    /// </summary>
    public GameObject archer;

    /// <summary>
    /// Defines the viking
    /// </summary>
    public GameObject viking;

    /// <summary>
    /// Defines the wizard
    /// </summary>
    public GameObject wizard;

    /// <summary>
    /// Defines the player4
    /// </summary>
    public GameObject player4;

    /// <summary>
    /// Defines the isMelee
    /// </summary>
    private bool isMelee;

    /// <summary>
    /// The Start
    /// </summary>
    internal void Start()
    {
        findPlayer4();
    }

    /// <summary>
    /// The findPlayer4
    /// </summary>
    public void findPlayer4()
    {

        if (PlayerValues.P4knight)
        {
            Destroy(player4);
            player4 = Instantiate(knight, spawnPoint);
            isMelee = true;

        }
        else if (PlayerValues.P4archer)
        {
            Destroy(player4);
            player4 = Instantiate(archer, spawnPoint);
            isMelee = false;
        }
        else if (PlayerValues.P4viking)
        {
            Destroy(player4);
            player4 = Instantiate(viking, spawnPoint);
            isMelee = true;
        }
        else if (PlayerValues.P4wizard)
        {
            Destroy(player4);
            player4 = Instantiate(wizard, spawnPoint);
            isMelee = false;
        }
        else
        {
            return;
        }

        player4.transform.gameObject.tag = "player4";
        player4.GetComponent<PlayerControl>().playerId = 3;
        player4.GetComponent<PlayerControl>().isMelee = isMelee;
        player4.GetComponent<ChangeColor>().playerNumber = 4;
        player4.GetComponent<ActivatePlayerTag>().player = "player4";
    }

    /// <summary>
    /// The DestroyPlayer
    /// </summary>
    public void DestroyPlayer()
    {
        Destroy(player4);
    }
}
