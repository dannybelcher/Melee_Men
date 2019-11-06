using UnityEngine;

/// <summary>
/// Defines the <see cref="Player2Spawner" />
/// </summary>
public class Player2Spawner : MonoBehaviour
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
    /// Defines the player2
    /// </summary>
    public GameObject player2;

    /// <summary>
    /// Defines the isMelee
    /// </summary>
    private bool isMelee;

    /// <summary>
    /// The Start
    /// </summary>
    internal void Start()
    {
        findPlayer2();
    }

    /// <summary>
    /// The findPlayer2
    /// </summary>
    public void findPlayer2()
    {

        if (PlayerValues.P2knight)
        {
            Destroy(player2);
            player2 = Instantiate(knight, spawnPoint);
            isMelee = true;

        }
        else if (PlayerValues.P2archer)
        {
            Destroy(player2);
            player2 = Instantiate(archer, spawnPoint);
            isMelee = false;
        }
        else if (PlayerValues.P2viking)
        {
            Destroy(player2);
            player2 = Instantiate(viking, spawnPoint);
            isMelee = true;
        }
        else if (PlayerValues.P2wizard)
        {
            Destroy(player2);
            player2 = Instantiate(wizard, spawnPoint);
            isMelee = false;
        }
        else
        {
            return;
        }

        player2.transform.gameObject.tag = "player2";
        player2.GetComponent<PlayerControl>().playerId = 1;
        player2.GetComponent<PlayerControl>().isMelee = isMelee;
        player2.GetComponent<ChangeColor>().playerNumber = 2;
        player2.GetComponent<ActivatePlayerTag>().player = "player2";
    }

    /// <summary>
    /// The DestroyPlayer
    /// </summary>
    public void DestroyPlayer()
    {
        Destroy(player2);
    }
}
