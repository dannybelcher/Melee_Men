using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// Defines the <see cref="Pauser" />
/// </summary>
public class Pauser : MonoBehaviour
{
    /// <summary>
    /// Defines the paused
    /// </summary>
    private bool paused = false;

    /// <summary>
    /// Defines the pauseObjects
    /// </summary>
    internal GameObject[] pauseObjects;

    /// <summary>
    /// Defines the sim
    /// </summary>
    internal StandaloneInputModule sim;

    /// <summary>
    /// The Start
    /// </summary>
    private void Start()
    {
        pauseObjects = GameObject.FindGameObjectsWithTag("pause");
        hidePaused();
    }

    // Update is called once per frame
    /// <summary>
    /// The Update
    /// </summary>
    internal void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            togglePause();
        }
        if (Input.GetButtonDown("P1_Start"))
        {
            togglePause();
            setSIM("P1");
        }
        if (Input.GetButtonDown("P2_Start"))
        {
            togglePause();
            setSIM("P2");
        }
        if (Input.GetButtonDown("P3_Start"))
        {
            togglePause();
            setSIM("P3");
        }
        if (Input.GetButtonDown("P4_Start"))
        {
            togglePause();
            setSIM("P4");
        }
    }

    /// <summary>
    /// The togglePause
    /// </summary>
    public void togglePause()
    {
        if (paused)
        {
            Time.timeScale = 1f;
            paused = false;
            hidePaused();
        }
        else
        {
            Time.timeScale = 0f;
            paused = true;
            showPaused();


        }
    }

    /// <summary>
    /// The showPaused
    /// </summary>
    public void showPaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(true);
        }
    }

    /// <summary>
    /// The hidePaused
    /// </summary>
    public void hidePaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }
    }

    /// <summary>
    /// The setSIM
    /// </summary>
    /// <param name="player">The player<see cref="string"/></param>
    internal void setSIM(string player)
    {
        if (player.Equals("P1"))
        {
            sim.horizontalAxis = "P1_Dpad_Horizontal";
            sim.verticalAxis = "P1_Dpad_Vertical";
            sim.submitButton = "P1_Submit";
            sim.cancelButton = "P1_Cancel";
        }
        if (player.Equals("P2"))
        {

            sim.horizontalAxis = "P2_Dpad_Horizontal";
            sim.verticalAxis = "P2_Dpad_Vertical";
            sim.submitButton = "P2_Submit";
            sim.cancelButton = "P2_Cancel";
        }
        if (player.Equals("P3"))
        {

            sim.horizontalAxis = "P3_Dpad_Horizontal";
            sim.verticalAxis = "P3_Dpad_Vertical";
            sim.submitButton = "P3_Submit";
            sim.cancelButton = "P3_Cancel";
        }
        if (player.Equals("P4"))
        {
            sim.horizontalAxis = "P4_Dpad_Horizontal";
            sim.verticalAxis = "P4_Dpad_Vertical";
            sim.submitButton = "P4_Submit";
            sim.cancelButton = "P4_Cancel";
        }
    }
}
