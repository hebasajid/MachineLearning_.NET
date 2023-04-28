﻿
// This file was auto-generated by ML.NET Model Builder. 

using MLKnowledgeModel_ConsoleApp;

// Create single instance of sample data from first line of dataset for model input
MLKnowledgeModel.ModelInput sampleData = new MLKnowledgeModel.ModelInput()
{
    STG = 0.08F,
    SCG = 0.08F,
    STR = 0.1F,
    LPR = 0.24F,
    PEG = 0.9F,
};

// Make a single prediction on the sample data and print results
var predictionResult = MLKnowledgeModel.Predict(sampleData);

Console.WriteLine("Using model to make single prediction -- Comparing actual UNS with predicted UNS from sample data...\n\n");


Console.WriteLine($"STG: {0.08F}");
Console.WriteLine($"SCG: {0.08F}");
Console.WriteLine($"STR: {0.1F}");
Console.WriteLine($"LPR: {0.24F}");
Console.WriteLine($"PEG: {0.9F}");
Console.WriteLine($"UNS: {@"High"}");


Console.WriteLine($"\n\nPredicted UNS: {predictionResult.PredictedLabel}\n\n");
Console.WriteLine("=============== End of process, hit any key to finish ===============");
Console.ReadKey();

