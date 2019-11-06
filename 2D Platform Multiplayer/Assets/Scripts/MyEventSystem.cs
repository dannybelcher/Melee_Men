using UnityEngine.EventSystems;

/// <summary>
/// Defines the <see cref="MyEventSystem" />
/// </summary>
public class MyEventSystem : EventSystem
{
    /// <summary>
    /// The OnEnable
    /// </summary>
    protected override void OnEnable()
    {
        base.OnEnable();
    }

    /// <summary>
    /// The Update
    /// </summary>
    protected override void Update()
    {
        EventSystem originalCurrent = EventSystem.current;
        current = this;
        base.Update();
        current = originalCurrent;
    }
}
