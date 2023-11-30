using Profanity_detector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace profanity_detector.Model.Service
{
    internal class ModelService
    {
        public string Detect(string content)
        {
            return ProfanityChecker.Predict(new ProfanityChecker.ModelInput() { Text = content }).ToString();
        }
    }
}
