using System;

namespace rKeeper_c.airn
{
    public class BFA
    {
        public DateTime ConductedDate;
        public int Pushups;
        public int Situps;
        public string Run;

        public BFA(DateTime conductedDate, int pushups, int situps, string run)
        {
            this.ConductedDate = conductedDate;
            this.Pushups = pushups;
            this.Situps = situps;
            this.Run = run;
        }
    }
}
