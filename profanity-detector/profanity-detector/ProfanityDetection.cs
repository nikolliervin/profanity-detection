using profanity_detector.Model.Service;
using System;

namespace profanity_detector
{   
    public class ProfanityDetection
    {
        private readonly ModelService _modelService;
        public ProfanityDetection()
        {
            _modelService = new ModelService();
        }

        /// <summary>
        /// Detects whether the provided content is toxic.
        /// </summary>
        /// <param name="content">The content to analyze for toxicity.</param>
        /// <returns>
        ///   <c>true</c> if the content is detected as toxic; otherwise, <c>false</c>.
        /// </returns>
        public bool isToxic(string content)
        {
            var resp = _modelService.Detect(content);

            if (resp == "Toxic")
                return true;

            return false;
        }


    }
}
