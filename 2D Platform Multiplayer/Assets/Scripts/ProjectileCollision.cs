using UnityEngine;

/// <summary>
/// Defines the <see cref="ProjectileCollision" />
/// </summary>
public class ProjectileCollision : MonoBehaviour
{
    /// <summary>
    /// Defines the explosion
    /// </summary>
    public GameObject explosion;

    /// <summary>
    /// Defines the projectile
    /// </summary>
    public GameObject projectile;

    /// <summary>
    /// The OnCollisionEnter2D
    /// </summary>
    /// <param name="collision">The collision<see cref="Collision2D"/></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject explo = Instantiate(explosion, transform.position, Quaternion.Euler(new Vector3(0, 0, 0)));
        Destroy(explo, 1f);
        Destroy(projectile);
    }
}
