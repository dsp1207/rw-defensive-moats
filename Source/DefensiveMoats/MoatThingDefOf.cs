using RimWorld;
using Verse;

namespace DefensiveMoats
{
    [DefOf]
    public static class MoatThingDefOf
    {
        public static ThingDef Moat;

        public static ThingDef MoatBridgeWood;

        static MoatThingDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(MoatThingDefOf));
        }

    }
}