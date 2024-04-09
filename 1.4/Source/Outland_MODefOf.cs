using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;
using DefOf = RimWorld.DefOf;

namespace Outland_MedievalOverhaul
{
    [DefOf]
    public static class Outland_MODefOf
    {
        static Outland_MODefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(OutlandDefOf));
        }

        // Bones
        public static ThingDef Outland_Bones;
      

