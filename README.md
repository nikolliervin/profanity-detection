# Profanity Detector NuGet Package ![NuGet_project_logo svg](https://github.com/nikolliervin/profanity-decetion/assets/45341025/5346663e-0a3f-4960-b2d6-e6663369dd0a)


## Overview

This package is designed to help you easily identify and detect profanity or bad words within a given sentence or string. It leverages a simple binary classifier that has been built and trained for accurate and efficient detection of inappropriate language.

## Installation

To get started, install the Profanity Detector NuGet package into your project. You can do this using the following command in the Package Manager Console:

```bash
NuGet\Install-Package nikolliervin.profanity-detector -Version 1.0.1
```
```bash
dotnet add package nikolliervin.profanity-detector --version 1.0.1
```


## Usage

Once the package is installed, integrating it into your code is straightforward. Here's a simple example of how to use the Profanity Detector:

```csharp
using profanity_detector;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the ProfanityDetection class
        var profanityDetector = new ProfanityDetection();

        // Detect profanity in a string
        var hasProfanity = profanityDetector.Detect("string to detect");

        // 'hasProfanity' will be true if profanity is detected, otherwise false
        if (hasProfanity)
        {
            Console.WriteLine("Profanity detected in the provided string!");
            // Handle the profanity as needed
        }
        else
        {
            Console.WriteLine("No profanity detected. The string is clean!");
        }
    }
}


```
## How it Works

The Profanity Detector utilizes a simple binary classifier that has been built and trained to distinguish between clean and profane language. The underlying algorithm analyzes the input string and returns `true` if it contains bad words and `false` otherwise.

## Note

While the Profanity Detector is effective in identifying common profanity and bad words, but it may not be exhaustive. I am actively working to increase the accuracy of the detection.

## Feedback and Contributions

We welcome your feedback! If you encounter any issues, have suggestions for improvement, or want to contribute to the project, please visit our GitHub repository https://github.com/nikolliervin/profanity-decetion and create an issue or pull request.

Thank you for using the Profanity Detector NuGet package! We hope it proves to be a valuable tool in maintaining a clean and respectful environment within your applications.
