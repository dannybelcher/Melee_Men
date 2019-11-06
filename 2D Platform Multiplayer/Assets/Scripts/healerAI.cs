using UnityEngine;

/// <summary>
/// Defines the <see cref="HealerAI" />
/// </summary>
public class HealerAI : MonoBehaviour
{
    /// <summary>
    /// Defines the speed
    /// </summary>
    public float speed = 3.0f;

    /// <summary>
    /// Defines the target
    /// </summary>
    private Vector2 target;

    /// <summary>
    /// Defines the position
    /// </summary>
    private Vector2 position;

    /// <summary>
    /// Defines the particleEffect
    /// </summary>
    public GameObject particleEffect;

    /// <summary>
    /// The Start
    /// </summary>
    internal void Start()
    {
    }

    /// <summary>
    /// The Update
    /// </summary>
    internal void Update()
    {

        findPlayer();

        ////Debug.Log(playerLoc.location);
        float step = speed * Time.deltaTime;

        // move sprite towards the target location
        transform.position = Vector2.MoveTowards(transform.position, target, step);
    }

    /// <summary>
    /// The findPlayer
    /// </summary>
    internal void findPlayer()
    {
        Transform player = GameObject.FindGameObjectWithTag("player1").transform;
        target = player.transform.position;
    }

    /// <summary>
    /// The OnCollisionEnter2D
    /// </summary>
    /// <param name="collision">The collision<see cref="Collision2D"/></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("ground"))
        {
            Destroy(gameObject);
            GameObject particle = Instantiate(particleEffect, transform.position, Quaternion.Euler(new Vector3(0, 0, 0)));
            Destroy(particle, 0.3f);
        }
    }
}
