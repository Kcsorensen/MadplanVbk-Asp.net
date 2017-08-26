using System.Collections.Generic;

namespace SharedLib.Models
{
    public class QuantityType
    {
        // Singleton
        public static QuantityType Current = new QuantityType();

        public const string spsk = "spsk.";
        public const string stk = "stk.";
        public const string Ingen = "Ingen";
        public const string skive = "skive(r)";
        public const string tsk = "tsk.";
        public const string dl = "dl.";
        public const string knsp = "knsp.";
        public const string gram = "gram";
        public const string dåse = "dåse(r)";
        public const string dråbe = "dråbe(r)";
        public const string pakke = "pakke(r)";
        public const string plade = "plade(r)";
        public const string pose = "pose(r)";

        public List<string> CompleteListOfQuantityTypes { get; set; }
        public List<string> ListForQuantityConverter { get; set; }

        public QuantityType()
        {
            CompleteListOfQuantityTypes = new List<string>()
            {
                spsk,
                stk,
                Ingen,
                skive,
                tsk,
                dl,
                knsp,
                gram,
                dåse,
                dråbe,
                pakke,
                plade,
                pose
            };

            ListForQuantityConverter = new List<string>()
            {
                spsk,
                stk,
                skive,
                tsk,
                dl,
                knsp,
                dåse,
                dråbe,
                pakke,
                plade,
                pose
            };
        }

    }
}
