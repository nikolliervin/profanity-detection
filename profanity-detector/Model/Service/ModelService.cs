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
        /// <summary>
        /// Detects the model input
        /// </summary>
        /// <param name="content">The string content to analyze</param>
        /// <returns>
        ///   <c>Toxic</c> If the content of the string is toxic, otherwise it returns <c>Not Toxic</c>.
        /// </returns>
        public string Detect(string content)
        {
            return ProfanityChecker.Predict(new ProfanityChecker.ModelInput() { Text = content }).PredictedLabel;
     
        }
    }
}
