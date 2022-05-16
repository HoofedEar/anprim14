using Content.Server.Destructible.Thresholds;

namespace Content.Server.Destructible
{
    /// <summary>
    ///     When attached to an <see cref="Robust.Shared.GameObjects.EntityUid"/>, allows it to take damage
    ///     and triggers thresholds when reached.
    /// </summary>
    [RegisterComponent]
    public sealed class DestructibleComponent : Component
    {
        [ViewVariables]
        [DataField("thresholds")]
        public List<DamageThreshold> Thresholds = new();

    }
}
