using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;

namespace Interface
{
    public static class InputCheck
    {
        static Regex cadrFormatCheck = new Regex(@"^[0-9]+[xх]{1}[0-9]+$");
        static Regex cornerGripCheck = new Regex(@"^[0-9]{1,3}[xх]{1}[0-9]{1,3}$");
        static Regex angularPositionCamCheck = new Regex(@"^[0-9]{1,3}:[0-9]{1,3}:[0-9]{1,3}$");
        static Regex matrixPeriodCheck = new Regex(@"^[0-9]+:[0-9]+$");
        static Regex flightHeighChangeCheck = new Regex(@"^[-+]{1}[0-9]+$");
        static Regex speedProectionCheck = new Regex(@"^[0-9]{1,3}:[0-9]{1,3}:[0-9]{1,3}$");
        static Regex angularPositionLACheck = new Regex(@"^[0-9]{1,3}:[0-9]{1,3}:[0-9]{1,3}$");
        static Regex pairOfCoordinatesCheck = new Regex(@"^[\d]+;[\d]+$");

        private static string cadrFormarError = "Недопустимый формат кадра";
        private static string cornerGripError = "Недопустимый угловой захват местности";
        private static string angularPositionCamError = "Недопустимое угловое положение камеры";
        private static string matrixPeriodError = "Недопустимый период матрицы";
        private static string flightHeighChangeError = "Недопустимое изменение высоты полета";
        private static string speedProectionError = "Недопустимые проекции скорости";
        private static string angularPositionLAError = "Недопустимое угловое положение ЛА";
        private static string pairOfCoordinatesError = "Недопустимые значения координат точки центра объекта";

        public static bool CheckInputCameraData(
            string cadrFormat,
            string cornerGrip,
            string angularPositionCam,
            string matrixPeriod,
            List<string> pairOfCoordinates)
        {
            if (!cadrFormatCheck.IsMatch(cadrFormat))
            {
                MessageBox.Show(cadrFormarError, "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            if (!cornerGripCheck.IsMatch(cornerGrip))
            {
                MessageBox.Show(cornerGripError, "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            if (!angularPositionCamCheck.IsMatch(angularPositionCam))
            {
                MessageBox.Show(angularPositionCamError, "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            if (!matrixPeriodCheck.IsMatch(matrixPeriod))
            {
                MessageBox.Show(matrixPeriodError, "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            foreach (string pairOfCoordinate in pairOfCoordinates)
            {
                if (!pairOfCoordinatesCheck.IsMatch(pairOfCoordinate))
                {
                    MessageBox.Show(pairOfCoordinatesError, "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
            }

            return true;
        }

        public static bool CheckInputLAData(
            string flightHeighChange,
            string speedProection,
            string angularPositionLA)
        {
            if (!flightHeighChangeCheck.IsMatch(flightHeighChange))
            {
                MessageBox.Show(flightHeighChangeError, "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            if (!speedProectionCheck.IsMatch(speedProection))
            {
                MessageBox.Show(speedProectionError, "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            if (!angularPositionLACheck.IsMatch(angularPositionLA))
            {
                MessageBox.Show(angularPositionLAError, "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            return true;
        }
    }
}
