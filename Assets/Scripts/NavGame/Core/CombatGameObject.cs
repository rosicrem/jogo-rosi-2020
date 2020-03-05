using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NavGame.Core
{

    public class CombatGameObject : DamageableGameObject
    {
        float cooldown = 0f;
        float lastAttackTime;

        protected virtual Update()
        { 

        }
        public void AttackOnCooldown(DamageableGameObject target)
        {
            DecrreaseAttackCoolDown();
        }

        void DecrreaseAttackCoolDown()
        {
            if(cooldown == 0f)
            {
                return;
            }
            cooldown = cooldown -= Time.deltaTime;
            if(cooldown < 0f)
            {
                cooldown = 0f;
            }
        }
    }
}