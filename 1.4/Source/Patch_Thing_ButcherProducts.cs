using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

using HarmonyLib;

namespace Outland_MedievalOverhaul
{
	[HarmonyPatch(typeof(Thing))]
	[HarmonyPatch("ButcherProducts")]
	public class RemoveBoneSpawnPatch
	{
		[HarmonyAfter(new string[] { "Neronix17.Outland.Core" })]
		public static IEnumerable<Thing> Postfix(IEnumerable<Thing> result, Pawn butcher, float efficiency)
		{
			foreach (Thing t in result)
			{
				if (thing.def == Outland_MODefOf.Outland_Bones)
				{
					yield return t;
				}
			}		
		}
	}
}
