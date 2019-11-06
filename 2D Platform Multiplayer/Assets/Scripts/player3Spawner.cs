using UnityEngine;

/// <summary>
/// Defines the <see cref="player3Spawner" />
/// </summary>
public class player3Spawner : MonoBehaviour
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
    /// Defines the player3
    /// </summary>
    public GameObject player3;

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
        findPlayer3();
    }

    /// <summary>
    /// The findPlayer3
    /// </summary>
    public void findPlayer3()
    {

        if (PlayerValues.P3knight)
        {
            Destroy(player3);
            player3 = Instantiate(knight, spawnPoint);
            isMelee = true;

        }
        else if (PlayerValues.P3archer)
        {
            Destroy(player3);
            player3 = Instantiate(archer, spawnPoint);
            isMelee = false;
        }
        else if (PlayerValues.P3viking)
        {
            Destroy(player3);
            player3 = Instantiate(viking, spawnPoint);
            isMelee = true;
        }
        else if (PlayerValues.P3wizard)
        {
            Destroy(player3);
            player3 = Instantiate(wizard, spawnPoint);
            isMelee = false;
        }
        else
        {
            return;
        }

        player3.transform.gameObject.tag = "player3";
        player3.GetComponent<PlayerControl>().playerId = 2;
        //player3.GetComponent<PlayerControl>().horiztonal = "P3_Horizontal";
        //player3.GetComponent<PlayerControl>().jumpButton = "P3_Jump";
        player3.GetComponent<PlayerControl>().isMelee = isMelee;
        //player3.GetComponent<PlayerControl>().attack = "P3_Fire";
        player3.GetComponent<ChangeColor>().playerNumber = 3;
        player3.GetComponent<ActivatePlayerTag>().player = "player3";
    }

    /// <summary>
    /// The DestroyPlayer
    /// </summary>
    public void DestroyPlayer()
    {
        Destroy(player3);
    }
}
