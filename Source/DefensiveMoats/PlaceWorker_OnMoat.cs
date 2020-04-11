using Verse;

namespace DefensiveMoats
{
    public class PlaceWorker_OnMoat : PlaceWorker
	{
		public override AcceptanceReport AllowsPlacing(BuildableDef checkingDef, IntVec3 loc, Rot4 rot, Map map, Thing thingToIgnore = null, Thing thing = null)
		{
			Thing currentThing = map.thingGrid.ThingAt(loc, MoatThingDefOf.Moat);
			if (currentThing == null || currentThing.Position != loc)
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

