
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Analytics.Data
{
    public sealed class Visitor
    {
        public sealed class Dimensions
        {
            
            [DescriptionAttribute("A boolean indicating if a visitor is new or returning. Possible values: New Visitor, Returning Visitor.")]
            public static DataItem visitorType = new DataItem("visitorType");
                                      
            [DescriptionAttribute("The visit index for a visitor to your property. Each visit from a unique visitor will get its own incremental index starting from 1 for the first visit. Subsequent visits do not change previous visit indicies. For example, if a certain visitor has 4 visits to your website, visitCount for that visitor will have 4 distinct values of 1 through 4.")]
            public static DataItem visitCount = new DataItem("visitCount");
                                      
            [DescriptionAttribute("The number of days elapsed since visitors last visited your property. Used to calculate visitor loyalty.")]
            public static DataItem daysSinceLastVisit = new DataItem("daysSinceLastVisit");
                                      
            [DescriptionAttribute("The filter provided when you define custom visitor segments for your property.")]
            public static DataItem userDefinedValue = new DataItem("userDefinedValue");
                                      
        }

        public sealed class Metrics
        {
            
            [DescriptionAttribute("Total number of visitors to your property for the requested time period.")]
            public static DataItem visitors = new DataItem("visitors");
                                      
            [DescriptionAttribute("The number of visitors whose visit to your property was marked as a first-time visit.")]
            public static DataItem newVisits = new DataItem("newVisits");
                                      

            public sealed class Calculated
            {
                
            [DescriptionAttribute("The percentage of visits by people who had never visited your property before. (ga:newVisits / ga:visits ) ")]
            public static DataItem percentNewVisits = new DataItem("percentNewVisits");
                                      
            }
        }
    }
}
