using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlexiSurvey_V1._0.Models
{
    public class StandaloneSurveyModel
    {
        public int Id { get; set; }

        public string SurveyName { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public bool IsActive { get; set; }
    }
}
