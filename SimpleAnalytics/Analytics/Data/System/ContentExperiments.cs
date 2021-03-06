
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Analytics.Data
{
    public sealed class ContentExperiments
    {
        public sealed class Dimensions
        {
            
            [DescriptionAttribute("The visitor-scoped id of the content experiment that the user was exposed to when the metrics were reported.")]
            public static DataItem experimentId = new DataItem("experimentId");
                                      
            [DescriptionAttribute("The visitor-scoped id of the particular variation that the user was exposed to during a content experiment.")]
            public static DataItem experimentVariant = new DataItem("experimentVariant");
                                      
        }

        public sealed class Metrics
        {
            

            public sealed class Calculated
            {
                
            }
        }
    }
}
