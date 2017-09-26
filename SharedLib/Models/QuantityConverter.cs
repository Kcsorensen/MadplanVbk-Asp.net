using System.Collections.Generic;

namespace SharedLib.Models
{
    public class QuantityConverter 
    {
        //public List<Quantity> Quantities { get; set; }

        public double spsk { get; set; }
        public double stk { get; set; }
        public double skive { get; set; }
        public double tsk { get; set; }
        public double dl { get; set; }
        public double knsp { get; set; }
        public double dåse { get; set; }
        public double dråbe { get; set; }
        public double pakke { get; set; }
        public double plade { get; set; }
        public double pose { get; set; }

        public QuantityConverter()
        {
            Clear();
        }

        public void Clear()
        {
            spsk = 0;
            stk = 0;
            skive = 0;
            tsk = 0;
            dl = 0;
            knsp = 0;
            dåse = 0;
            dråbe = 0;
            pakke = 0;
            plade = 0;
            pose = 0;
        }
    }
}
