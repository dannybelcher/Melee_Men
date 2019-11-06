using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>
/// Defines the <see cref="MyButton" />
/// </summary>
public class MyButton : Button
{
    /// <summary>
    /// Defines the eventSystem
    /// </summary>
    public EventSystem eventSystem;

    /// <summary>
    /// The Awake
    /// </summary>
    protected override void Awake()
    {
        base.Awake();
        eventSystem = GetComponent<MyEventSystemProvider>().eventSystem;
    }

    /// <summary>
    /// The OnPointerDown
    /// </summary>
    /// <param name="eventData">The eventData<see cref="PointerEventData"/></param>
    public override void OnPointerDown(PointerEventData eventData)
    {
        if (eventData.button != PointerEventData.InputButton.Left)
            return;

        // Selection tracking
        if (IsInteractable() && navigation.mode != Navigation.Mode.None)
            eventSystem.SetSelectedGameObject(gameObject, eventData);

        base.OnPointerDown(eventData);
    }

    /// <summary>
    /// The Select
    /// </summary>
    public override void Select()
    {
        if (eventSystem.alreadySelecting)
            return;

        eventSystem.SetSelectedGameObject(gameObject);
    }
}
