using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models.HomeViewModels;

namespace WebApplication.Models
{
    public class InputDataModel
    {
        /// <summary>
        /// [Нo] Высота слоя, м
        /// </summary>
        public double LayerHeight { get; set; }
        /// <summary>
        /// [t'] Начальная температура материала, *С
        /// </summary>
        public double MaterialStartTemperature { get; set; }
        /// <summary>
        /// [T'] Начальная температура газа, *C
        /// </summary>
        public double GasStartTemperature { get; set; }
        /// <summary>
        /// [wг] Скорость газа на свободное сечение шахты, м/с
        /// </summary>
        public double GasSpeedFreeCrossSection { get; set; }
        /// <summary>
        /// [Сг] Средняя теплоёмкость газа, кДж/(м3 • К)
        /// </summary>
        public double GasAverageHeatСapacity { get; set; }
        /// <summary>
        /// [Gм] Расход материалов, кг/с
        /// </summary>
        public double MaterialConsumption { get; set; }
        /// <summary>
        /// [См] Теплоёмкость материалов, кДж/(кг • К)
        /// </summary>
        public double MaterialHeatCapacity { get; set; }
        /// <summary>
        /// [αV] Объемный коэффициент теплоотдачи, Вт/(м3 • К)
        /// </summary>
        public double VolumeHeatTransferCoefficient { get; set; }
        /// <summary>
        /// [D] Диаметр аппарата, м
        /// </summary>
        public double DeviceDiameter { get; set; }

        public static InputDataModel GetDefaultData()
        {
            return new InputDataModel
            {
                LayerHeight = 3,
                MaterialStartTemperature = 20,
                GasStartTemperature = 650,
                GasSpeedFreeCrossSection = 0.73,
                GasAverageHeatСapacity = 1.08,
                MaterialConsumption = 1.66,
                MaterialHeatCapacity = 1.49,
                VolumeHeatTransferCoefficient = 2430,
                DeviceDiameter = 2.3,
            };
        }
    }
}
