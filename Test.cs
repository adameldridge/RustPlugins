

namespace Oxide.Plugins
{
    [Info("Adam Test", "Test", "1.0.0")]
    [Description("Test Plugin")]

    public class Test : RustPlugin
    {
        void OnWeaponFired(BaseProjectile projectile, BasePlayer player, ItemModProjectile mod, ProtoBuf.ProjectileShoot projectiles)
        {
            Puts("OnWeaponFired works!");
            player.ChatMessage("You fired a gun!!");
        }
    }
}
