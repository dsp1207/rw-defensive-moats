using System;
using DefensiveMoats;
using Verse;
using RimWorld;

namespace DefensiveMoats
{
	public class PlaceWorker_OnMoat : PlaceWorker
	{
		public override AcceptanceReport AllowsPlacing(BuildableDef checkingDef, IntVec3 loc, Rot4 rot, Map map, Thing thingToIgnore = null)
		{
			Thing thing = map.thingGrid.ThingAt(loc, MoatThingDefOf.Moat);
			if (thing == null || thing.Position != loc)
			{
				return "MustPlaceOnMoat".Translate();
			}
			return true;
		}

		public override bool ForceAllowPlaceOver(BuildableDef otherDef)
		{
			return otherDef == MoatThingDefOf.Moat;
		}
	}
}

