using System.Reflection;
using RimWorld;
using Verse;
using Verse.AI;
using Verse.AI.Group;

namespace KB_Party_Your_Ass_Off;

public class FloatMenuOptionProvider_Party_Your_Ass_Off : FloatMenuOptionProvider
{
    protected override bool Drafted => false;

    protected override bool Undrafted => true;

    protected override bool Multiselect => false;

    protected override FloatMenuOption GetSingleOptionFor(Thing clickedThing, FloatMenuContext context)
    {
        if (!GatheringDefOf.Party.gatherSpotDefs.Contains(clickedThing.def))
        {
            return null;
        }

        if (!clickedThing.Position.Standable(clickedThing.Map) ||
            clickedThing.Position.IsForbidden(context.FirstSelectedPawn) ||
            !context.FirstSelectedPawn.CanReach(clickedThing, PathEndMode.OnCell, Danger.Deadly))
        {
            return new FloatMenuOption(
                "CM_Party_Your_Ass_Off_Cannot_Party_Here".Translate() + ": " + "NoPath".Translate().CapitalizeFirst(),
                null);
        }

        return FloatMenuUtility.DecoratePrioritizedTask(new FloatMenuOption(
            "CM_Party_Your_Ass_Off_Throw_Party_Here".Translate(), delegate
            {
                if (!TryStartParty(GatheringDefOf.Party, context.FirstSelectedPawn, clickedThing.Position))
                {
                    return;
                }

                // Let the VoluntarilyJoinableLordsStarter for this map know we are throwing a party so we don't get a random party directly after
                var map = clickedThing.Map;
                if (map.lordsStarter == null)
                {
                    return;
                }

                var lastLordStartTickField =
                    typeof(VoluntarilyJoinableLordsStarter).GetField("lastLordStartTick",
                        BindingFlags.NonPublic | BindingFlags.Instance);
                if (lastLordStartTickField != null)
                {
                    lastLordStartTickField.SetValue(map.lordsStarter,
                        Find.TickManager.TicksGame);
                }
            }, MenuOptionPriority.High), context.FirstSelectedPawn, clickedThing);
    }

    private static bool TryStartParty(GatheringDef gatheringDef, Pawn organizer, IntVec3 spot)
    {
        var createLordJobMethod =
            gatheringDef.workerClass.GetMethod("CreateLordJob", BindingFlags.NonPublic | BindingFlags.Instance);
        var lordJob = (LordJob)createLordJobMethod?.Invoke(gatheringDef.Worker, [spot, organizer]);

        LordMaker.MakeNewLord(organizer.Faction, lordJob, organizer.Map, lordJob is { OrganizerIsStartingPawn: false }
            ? null
            : new[]
            {
                organizer
            });

        var sendLetterMethod =
            gatheringDef.workerClass.GetMethod("SendLetter", BindingFlags.NonPublic | BindingFlags.Instance);
        sendLetterMethod?.Invoke(gatheringDef.Worker, [spot, organizer]);

        return true;
    }
}