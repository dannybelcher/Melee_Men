using System.Collections;
using UnityEngine;

/// <summary>
/// Defines the <see cref="ShootingProjectile" />
/// </summary>
public class ShootingProjectile : MonoBehaviour
{
    /// <summary>
    /// Defines the projectile
    /// </summary>
    public Rigidbody2D projectile;// Prefab of the rocket.

    /// <summary>
    /// Defines the speed
    /// </summary>
    public float speed = 20f;// The speed the rocket will fire at.

    /// <summary>
    /// Defines the gunFire
    /// </summary>
    public string gunFire;

    /// <summary>
    /// Defines the playerCtrl
    /// </summary>
    private PlayerControl playerCtrl;// Reference to the PlayerControl script.

    /// <summary>
    /// Defines the anim
    /// </summary>
    private Animator anim;// Reference to the Animator component.

    /// <summary>
    /// Defines the isCooldown
    /// </summary>
    private bool isCooldown;

    /// <summary>
    /// The Awake
    /// </summary>
    internal void Awake()
    {
        PlayerControl pc = new PlayerControl();
        gunFire = "no";
        isCooldown = true;
        // Setting up the references.

        playerCtrl = transform.root.GetComponent<PlayerControl>();
    }

    /// <summary>
    /// The Update
    /// </summary>
    internal void Update()
    {
        projectile.gravityScale = 0;
        // If the fire button is pressed...
        if (Input.GetButtonDown(gunFire) && isCooldown)
        {

            StartCoroutine(Cooldown());

        }
    }

    /// <summary>
    /// The destroyArrow
    /// </summary>
    public void destroyArrow()
    {
        Destroy(projectile);
    }

    /// <summary>
    /// The shootProjectile
    /// </summary>
    public void shootProjectile()
    {
        if (playerCtrl.facingRight)
        {
            // ... instantiate the rocket facing right and set it's velocity to the right. 
            Rigidbody2D bulletInstance = Instantiate(projectile, transform.position, Quaternion.Euler(new Vector3(0, 0, 0))) as Rigidbody2D;
            bulletInstance.velocity = new Vector2(speed, 0);
        }
        else
        {
            // Otherwise instantiate the rocket facing left and set it's velocity to the left.
            Rigidbody2D bulletInstance = Instantiate(projectile, transform.position, Quaternion.Euler(new Vector3(0, 0, 180f))) as Rigidbody2D;
            bulletInstance.velocity = new Vector2(-speed, 0);
        }
    }

    /// <summary>
    /// The Cooldown
    /// </summary>
    /// <returns>The <see cref="IEnumerator"/></returns>
    private IEnumerator Cooldown()
    {
        playerCtrl.activeState = 3;
        // Wait for time you want
        //yield return new WaitForSeconds(.3f);
        StartCoroutine(waitForAnim());

        isCooldown = false;
        // Stop cooldown
        yield return new WaitForSeconds(.8f);
        isCooldown = true;
    }

    /// <summary>
    /// The waitForAnim
    /// </summary>
    /// <returns>The <see cref="IEnumerator"/></returns>
    private IEnumerator waitForAnim()
    {
        yield return new WaitForSeconds(.3f);
        shootProjectile();
    }
}
