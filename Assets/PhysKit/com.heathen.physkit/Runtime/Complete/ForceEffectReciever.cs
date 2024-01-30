#if HE_SYSCORE

using System.Collections.Generic;
using UnityEngine;

namespace HeathenEngineering.PhysKit
{
    [RequireComponent(typeof(PhysicsData))]
    public class ForceEffectReciever : HeathenBehaviour
    {
        public BoolReference useAngular = new BoolReference(false);
        public BoolReference useLinear = new BoolReference(false);
        [Tooltip("How subseptable is this reciever to force effect fields")]
        public FloatReference sinsativity = new FloatReference(1f);
        [HideInInspector]
        public PhysicsData data;

        private void Start()
        {
            data = GetComponent<PhysicsData>();
        }

        [Tooltip("List of triggered effectors e.g. effectors that are not managed as global")]
        public List<ForceEffectSource> Effectors = new List<ForceEffectSource>();
        [Tooltip("List of effect fields to ignore")]
        public List<ForceEffectSource> IgnoreList = new List<ForceEffectSource>();

        private void FixedUpdate()
        {
            if(data != null)
            {
                foreach(var field in API.ForceEffects.GlobalEffects)
                {
                    if (!IgnoreList.Contains(field))
                        field.AddForce(data, sinsativity.Value, useAngular.Value, useLinear.Value);
                }
            }

            if (data != null && Effectors != null && Effectors.Count > 0)
            {
                foreach (var field in Effectors)
                {
                    if (field.enabled && field.gameObject.activeInHierarchy && sinsativity.Value != 0)
                    {
                        if (!IgnoreList.Contains(field))
                            field.AddForce(data, sinsativity.Value, useAngular.Value, useLinear.Value);
                    }
                }
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            var field = other.gameObject.GetComponentInChildren<ForceEffectSource>();
            if(field != null && !Effectors.Contains(field))
            {
                Effectors.Add(field);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            var field = other.gameObject.GetComponentInChildren<ForceEffectSource>();
            if (field != null && Effectors.Contains(field))
            {
                Effectors.Remove(field);
            }
        }
    }
}


#endif