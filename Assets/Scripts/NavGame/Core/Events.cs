using UnityEngine;
namespace NavGame.Core
{
    //Character events

    public delegate void OnAttackHitEvent(Vector3 position);
    public delegate void OnHealthChangedEvent(int maxHealth, int currentHealth);
    public delegate void OnDiedEvent();
}

