using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class ResultDataModel
    {
        /// <summary>
        /// [S] Площадь поперечного сечения, м2
        /// </summary>
        public double СrossSectionalArea { get; set; }
        /// <summary>
        /// [Vг] Расход газа, м3/с
        /// </summary>
        public double GasConsumption { get; set; }
        /// <summary>
        /// [m] Отношение теплоемкостей потоков
        /// </summary>
        public double FlowHeatCapacitiesRatio { get; set; }
        /// <summary>
        /// [Yо] Полная относительная высота слоя 
        /// </summary>
        public double LayerTotalRelativeHeight { get; set; }
        /// <summary>
        /// 1 - m * exp ...
        /// </summary>
        public double CorrespondingAttitude { get; set; }

        /// <summary>
        /// Координаты для зависимостей
        /// </summary>
        public double[] Coordinates { get; set; }

        /// <summary>
        /// [t'] Массив температур материала, *С
        /// </summary>
        public double[] MaterialTemperatures { get; set; }
        /// <summary>
        /// [T'] Массив температур газа, *С
        /// </summary>
        public double[] GasTemperatures { get; set; }
        /// <summary>
        /// Разность температур, *С
        /// </summary>
        public double[] TemperatureDifferences { get; set; }
    }
}
