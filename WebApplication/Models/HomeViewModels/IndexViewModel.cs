using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models.HomeViewModels
{
    public class IndexViewModel
    {
        public InputDataModel Input { get; set; }
        public ResultDataModel Result { get; set; }

        public IndexViewModel()
        {
            Input = InputDataModel.GetDefaultData();
        }

         /// <summary>
        /// Расчётная функция
        /// </summary>
        /// <param name="input"></param>
        public void CalculateResult(InputDataModel input)
        {
            Result = new ResultDataModel();

            Result.СrossSectionalArea = Math.PI * Math.Pow(input.DeviceDiameter, 2) / 4;
            Result.GasConsumption = input.GasSpeedFreeCrossSection * Result.СrossSectionalArea;
            Result.FlowHeatCapacitiesRatio = input.MaterialConsumption * input.MaterialHeatCapacity / (Result.GasConsumption * input.GasAverageHeatСapacity);
            Result.LayerTotalRelativeHeight = input.VolumeHeatTransferCoefficient * Result.СrossSectionalArea * input.LayerHeight / (input.GasSpeedFreeCrossSection * Result.СrossSectionalArea * input.GasAverageHeatСapacity * 1000);
            Result.CorrespondingAttitude = 1 - Result.FlowHeatCapacitiesRatio * Math.Exp(-(1 - Result.FlowHeatCapacitiesRatio) * Result.LayerTotalRelativeHeight / Result.FlowHeatCapacitiesRatio);

           
            double[] coordinates = new double[] { 0, 0.5, 1, 1.5, 2, 2.5, 3 };

            Result.Coordinates = coordinates;
            Result.MaterialTemperatures = new double[coordinates.Length];
            Result.GasTemperatures = new double[coordinates.Length];
            Result.TemperatureDifferences = new double[coordinates.Length];

            for (int i = 0; i < coordinates.Length; i++)
            {
                double Y = input.VolumeHeatTransferCoefficient * coordinates[i] / (input.GasAverageHeatСapacity * input.GasSpeedFreeCrossSection * 1000);
                double Exp = 1 - Math.Exp((Result.FlowHeatCapacitiesRatio - 1) * Y / Result.FlowHeatCapacitiesRatio);
                double mExp = 1 - Result.FlowHeatCapacitiesRatio * Math.Exp((Result.FlowHeatCapacitiesRatio - 1) * Y / Result.FlowHeatCapacitiesRatio);
                double uCoeff = Exp / (1 - Result.FlowHeatCapacitiesRatio * Math.Exp((Result.FlowHeatCapacitiesRatio - 1) * Result.LayerTotalRelativeHeight / Result.FlowHeatCapacitiesRatio));
                double oCoeff = mExp / (1 - Result.FlowHeatCapacitiesRatio * Math.Exp((Result.FlowHeatCapacitiesRatio - 1) * Result.LayerTotalRelativeHeight / Result.FlowHeatCapacitiesRatio));

                Result.MaterialTemperatures[i] = input.MaterialStartTemperature + (input.GasStartTemperature - input.MaterialStartTemperature) * uCoeff;
                Result.GasTemperatures[i] = input.MaterialStartTemperature + (input.GasStartTemperature - input.MaterialStartTemperature) * oCoeff;
                Result.TemperatureDifferences[i] = Result.GasTemperatures[i] - Result.MaterialTemperatures[i];
            }
        }

    }
}
