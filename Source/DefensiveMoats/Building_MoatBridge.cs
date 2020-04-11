using Verse;

namespace DefensiveMoats
{
    public class Building_MoatBridge : Building
    {
        private Building_Moat moat;

		

        public override void SpawnSetup(Map map, bool respawningAfterLoad)
        {
            base.SpawnSetup(map, respawningAfterLoad);
			this.moat = (Building_Moat)this.Map.thingGrid.ThingAt(this.Position, MoatThingDefOf.Moat);
			this.moat.Destroy(DestroyMode.Vanish); 

		}
		public override void DeSpawn(DestroyMode mode = DestroyMode.Vanish)
		{
			Map map = base.Map;
			base.DeSpawn(mode);
			Thing newThing = ThingMaker.MakeThing(MoatThingDefOf.Moat, null);
			GenPlace.TryPlaceThing(newThing, this.Position, map, ThingPlaceMode.Direct, null, null);
		}
		

	}
}
