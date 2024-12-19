using Content.Server.Chat.Systems;
using Content.Shared.Chat;
using Content.Shared.Hands;

namespace Content.Server.Bullhorn;

public sealed class BullhornSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<BullhornComponent, GotEquippedHandEvent>(OnAmplifierEquipped);
        SubscribeLocalEvent<BullhornComponent, GotUnequippedHandEvent>(OnAmplifierUnequipped);
    }


    private void OnAmplifierEquipped(EntityUid uid, BullhornComponent component, GotEquippedHandEvent args)
    {
        EnsureComp<AmplifierComponent>(args.User).Amplification = 2f;
    }

    private void OnAmplifierUnequipped(EntityUid uid, BullhornComponent component, GotUnequippedHandEvent args)
    {
        RemCompDeferred<AmplifierComponent>(args.User);
    }
}
