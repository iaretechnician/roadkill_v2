#if HE_SYSCORE

using UnityEngine;
using System;

namespace HeathenEngineering.PhysKit
{
    /// <summary>
    /// Represents a node in a physics bone tree.
    /// </summary>
    [Serializable]
    public class VerletParticle
    {
        public Transform target;
        [HideInInspector]
        public VerletParticle parent;
        [HideInInspector]
        public float damping;
        [HideInInspector]
        public float elasticity;
        [HideInInspector]
        public float stiffness;
        [HideInInspector]
        public float inert;
        [HideInInspector]
        public float falloffAngle;
        [HideInInspector]
        public float collisionRadius;
        [HideInInspector]
        public float distance;
        [HideInInspector]
        public Vector3 addedForce;
        [HideInInspector]
        public float weight;
        [HideInInspector]
        public Vector3 position;
        [HideInInspector]
        public Vector3 prevPosition;
        [HideInInspector]
        public Vector3 initLocalPosition;
        [HideInInspector]
        public Quaternion initLocalRotation;
    }
}

#endif
