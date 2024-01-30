#if HE_SYSCORE

using UnityEngine;

namespace HeathenEngineering.PhysKit
{
    public abstract class ForceEffect : ScriptableObject, IForceEffect
    {
        public abstract void AngularEffect(Vector3 origin, float strength, PhysicsData subjectData);

        public abstract void LinearEffect(Vector3 origin, float strength, PhysicsData subjectData);
    }
}

#endif