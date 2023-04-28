﻿// This file was auto-generated by ML.NET Model Builder. 
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace Question3
{
    public partial class MLKnowledgeModel
    {
        /// <summary>
        /// model input class for MLKnowledgeModel.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [ColumnName(@"STG")]
            public float STG { get; set; }

            [ColumnName(@"SCG")]
            public float SCG { get; set; }

            [ColumnName(@"STR")]
            public float STR { get; set; }

            [ColumnName(@"LPR")]
            public float LPR { get; set; }

            [ColumnName(@"PEG")]
            public float PEG { get; set; }

            [ColumnName(@"UNS")]
            public string UNS { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for MLKnowledgeModel.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"STG")]
            public float STG { get; set; }

            [ColumnName(@"SCG")]
            public float SCG { get; set; }

            [ColumnName(@"STR")]
            public float STR { get; set; }

            [ColumnName(@"LPR")]
            public float LPR { get; set; }

            [ColumnName(@"PEG")]
            public float PEG { get; set; }

            [ColumnName(@"UNS")]
            public uint UNS { get; set; }

            [ColumnName(@"Features")]
            public float[] Features { get; set; }

            [ColumnName(@"PredictedLabel")]
            public string PredictedLabel { get; set; }

            [ColumnName(@"Score")]
            public float[] Score { get; set; }

        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("MLKnowledgeModel.zip");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }
    }
}
