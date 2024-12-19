namespace Content.Shared.Chat;

using Robust.Shared.GameStates;

[RegisterComponent]
public sealed partial class AmplifierComponent: Component
{
    [DataField("amplification")]
    public float Amplification = 2f;
}
