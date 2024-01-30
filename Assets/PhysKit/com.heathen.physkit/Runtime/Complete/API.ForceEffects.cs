﻿#if HE_SYSCORE
using System.Collections.Generic;
using UnityEngine;

namespace HeathenEngineering.PhysKit.API
{
    public static class ForceEffects
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        static void Init()
        {
            forceEffectFields = new List<ForceEffectSource>();
        }

        public static List<ForceEffectSource> GlobalEffects => forceEffectFields;

        private static List<ForceEffectSource> forceEffectFields = new List<ForceEffectSource>();
    }
}
#endif