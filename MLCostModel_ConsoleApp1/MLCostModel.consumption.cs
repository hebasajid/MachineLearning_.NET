﻿// This file was auto-generated by ML.NET Model Builder. 
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace MLCostModel_ConsoleApp1
{
    public partial class MLCostModel
    {
        /// <summary>
        /// model input class for MLCostModel.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [ColumnName(@"age")]
            public float Age { get; set; }

            [ColumnName(@"sex")]
            public string Sex { get; set; }

            [ColumnName(@"bmi")]
            public float Bmi { get; set; }

            [ColumnName(@"children")]
            public float Children { get; set; }

            [ColumnName(@"smoker")]
            public bool Smoker { get; set; }

            [ColumnName(@"region")]
            public string Region { get; set; }

            [ColumnName(@"charges")]
            public float Charges { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for MLCostModel.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"age")]
            public float Age { get; set; }

            [ColumnName(@"sex")]
            public float[] Sex { get; set; }

            [ColumnName(@"bmi")]
            public float Bmi { get; set; }

            [ColumnName(@"children")]
            public float Children { get; set; }

            [ColumnName(@"smoker")]
            public float[] Smoker { get; set; }

            [ColumnName(@"region")]
            public float[] Region { get; set; }

            [ColumnName(@"charges")]
            public float Charges { get; set; }

            [ColumnName(@"Features")]
            public float[] Features { get; set; }

            [ColumnName(@"Score")]
            public float Score { get; set; }

        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("MLCostModel.zip");

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
