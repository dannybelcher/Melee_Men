using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>
/// Defines the <see cref="PanelManager" />
/// </summary>
public class PanelManager : MonoBehaviour
{
    /// <summary>
    /// Defines the initiallyOpen
    /// </summary>
    public Animator initiallyOpen;

    /// <summary>
    /// Defines the m_OpenParameterId
    /// </summary>
    private int m_OpenParameterId;

    /// <summary>
    /// Defines the m_Open
    /// </summary>
    private Animator m_Open;

    /// <summary>
    /// Defines the m_PreviouslySelected
    /// </summary>
    private GameObject m_PreviouslySelected;

    /// <summary>
    /// Defines the k_OpenTransitionName
    /// </summary>
    internal const string k_OpenTransitionName = "Open";

    /// <summary>
    /// Defines the k_ClosedStateName
    /// </summary>
    internal const string k_ClosedStateName = "Closed";

    /// <summary>
    /// The OnEnable
    /// </summary>
    public void OnEnable()
    {
        m_OpenParameterId = Animator.StringToHash(k_OpenTransitionName);

        if (initiallyOpen == null)
            return;

        OpenPanel(initiallyOpen);
    }

    /// <summary>
    /// The OpenPanel
    /// </summary>
    /// <param name="anim">The anim<see cref="Animator"/></param>
    public void OpenPanel(Animator anim)
    {
        if (m_Open == anim)
            return;

        anim.gameObject.SetActive(true);
        var newPreviouslySelected = EventSystem.current.currentSelectedGameObject;

        anim.transform.SetAsLastSibling();

        CloseCurrent();

        m_PreviouslySelected = newPreviouslySelected;

        m_Open = anim;
        m_Open.SetBool(m_OpenParameterId, true);

        GameObject go = FindFirstEnabledSelectable(anim.gameObject);

        SetSelected(go);
    }

    /// <summary>
    /// The FindFirstEnabledSelectable
    /// </summary>
    /// <param name="gameObject">The gameObject<see cref="GameObject"/></param>
    /// <returns>The <see cref="GameObject"/></returns>
    internal static GameObject FindFirstEnabledSelectable(GameObject gameObject)
    {
        GameObject go = null;
        var selectables = gameObject.GetComponentsInChildren<Selectable>(true);
        foreach (var selectable in selectables)
        {
            if (selectable.IsActive() && selectable.IsInteractable())
            {
                go = selectable.gameObject;
                break;
            }
        }
        return go;
    }

    /// <summary>
    /// The CloseCurrent
    /// </summary>
    public void CloseCurrent()
    {
        if (m_Open == null)
            return;

        m_Open.SetBool(m_OpenParameterId, false);
        SetSelected(m_PreviouslySelected);
        StartCoroutine(DisablePanelDeleyed(m_Open));
        m_Open = null;
    }

    /// <summary>
    /// The DisablePanelDeleyed
    /// </summary>
    /// <param name="anim">The anim<see cref="Animator"/></param>
    /// <returns>The <see cref="IEnumerator"/></returns>
    internal IEnumerator DisablePanelDeleyed(Animator anim)
    {
        bool closedStateReached = false;
        bool wantToClose = true;
        while (!closedStateReached && wantToClose)
        {
            if (!anim.IsInTransition(0))
                closedStateReached = anim.GetCurrentAnimatorStateInfo(0).IsName(k_ClosedStateName);

            wantToClose = !anim.GetBool(m_OpenParameterId);

            yield return new WaitForEndOfFrame();
        }

        if (wantToClose)
            anim.gameObject.SetActive(false);
    }

    /// <summary>
    /// The SetSelected
    /// </summary>
    /// <param name="go">The go<see cref="GameObject"/></param>
    private void SetSelected(GameObject go)
    {
        EventSystem.current.SetSelectedGameObject(go);
    }
}
