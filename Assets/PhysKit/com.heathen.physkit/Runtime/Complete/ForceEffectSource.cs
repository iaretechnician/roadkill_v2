#if HE_SYSCORE

using UnityEngine;

namespace HeathenEngineering.PhysKit
{
    public abstract class ForceEffectSource : HeathenBehaviour
    {
        public abstract void AddForce(PhysicsData subject, float sinsativity, bool useAngular, bool useLinear);
    }
}

#endif
