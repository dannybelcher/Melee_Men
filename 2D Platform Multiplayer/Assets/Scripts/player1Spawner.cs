using UnityEngine;

/// <summary>
/// Defines the <see cref="Player1Spawner" />
/// </summary>
public class Player1Spawner : MonoBehaviour
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
    /// Defines the player1
    /// </summary>
    public GameObject player1;

    /// <summary>
    /// Defines the isMelee
    /// </summary>
    private bool isMelee;

    // Start is called before the first frame update
    /// <summary>
    /// The Start
    /// </summary>
    internal void Start()
    {
        findPlayer1();
    }

    /// <summary>
    /// The findPlayer1
    /// </summary>
    public void findPlayer1()
    {

        if (PlayerValues.P1knight)
        {
            Destroy(player1);
            player1 = Instantiate(knight, spawnPoint);
            isMelee = true;
        }
        else if (PlayerValues.P1archer)
        {
            Destroy(player1);
            player1 = Instantiate(archer, spawnPoint);
            isMelee = false;
        }
        else if (PlayerValues.P1viking)
        {
            Destroy(player1);
            player1 = Instantiate(viking, spawnPoint);
            isMelee = true;
        }
        else if (PlayerValues.P1wizard)
        {
            Destroy(player1);
            player1 = Instantiate(wizard, spawnPoint);
            isMelee = false;
        }
        else
        {
            return;
        }

        player1.transform.gameObject.tag = "player1";
        player1.GetComponent<PlayerControl>().playerId = 0;
        player1.GetComponent<PlayerControl>().isMelee = isMelee;
        player1.GetComponent<ChangeColor>().playerNumber = 1;
        player1.GetComponent<ActivatePlayerTag>().player = "player1";
    }

    /// <summary>
    /// The DestroyPlayer
    /// </summary>
    public void destroyPlayer()
    {
        Destroy(player1);
    }
}
