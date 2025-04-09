using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace TaskSolver
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 1; i <= 20; i++)
            {
                TaskSelector.Items.Add($"Task {i}");
            }
        }

        private void SolveButton_Click(object sender, RoutedEventArgs e)
        {
            int taskNumber = TaskSelector.SelectedIndex + 1;
            string result = SolveTask(taskNumber);
            ResultBox.Text = result;
        }

        private string SolveTask(int taskNumber)
        {
            switch (taskNumber)
            {
                case 1:
                    return SolveTask1();
                case 2:
                    return SolveTask2();
                case 3:
                    return SolveTask3();
                case 4:
                    return SolveTask4();
                case 5:
                    return SolveTask5();
                case 6:
                    return SolveTask6();
                case 7:
                    return SolveTask7();
                case 8:
                    return SolveTask8();
                case 9:
                    return SolveTask9();
                case 10:
                    return SolveTask10();
                case 11:
                    return SolveTask11();
                case 12:
                    return SolveTask12();
                case 13:
                    return SolveTask13();
                case 14:
                    return SolveTask14();
                case 15:
                    return SolveTask15();
                case 16:
                    return SolveTask16();
                case 17:
                    return SolveTask17();
                case 18:
                    return SolveTask18();
                case 19:
                    return SolveTask19();
                case 20:
                    return SolveTask20();
                default:
                    return "Task not implemented.";
            }
        }

        private string SolveTask1()
        {
            var points = new List<(double, double)>
            {
                (1, 2),
                (3, 4),
                (5, 6)
            };

            double radius = 5;
            (double, double) center = (0, 0);

            return $"Центр окружности: ({center.Item1}, {center.Item2}), Радиус: {radius}";
        }

        private string SolveTask2()
        {
            var surnames = new List<string> { "Иванов", "Петров", "Сидоров", "Кузнецов" };
            var results = new List<double> { 12.5, 11.8, 12.0, 11.9 };

            var bestRunners = surnames.Zip(results, (s, r) => new { Surname = s, Result = r })
                                     .OrderBy(x => x.Result)
                                     .Take(4)
                                     .Select(x => x.Surname)
                                     .ToList();

            return $"Лучшие бегуны: {string.Join(", ", bestRunners)}";
        }

        private string SolveTask3()
        {
            int[,] array = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = random.Next(1, 10);
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] *= -3;
                }
            }

            return $"Массив: {string.Join(", ", array.Cast<int>())}";
        }

        private string SolveTask4()
        {
            int[,] matrix = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                }
            }

            var belowDiagonal = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    belowDiagonal.Add(matrix[i, j]);
                }
            }

            belowDiagonal.Sort();

            return $"Элементы ниже главной диагонали: {string.Join(", ", belowDiagonal)}";
        }

        private string SolveTask5()
        {
            int[,] array = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = random.Next(1, 10);
                }
            }

            var flattenedArray = array.Cast<int>().ToArray();
            for (int i = 0; i < flattenedArray.Length - 1; i++)
            {
                for (int j = 0; j < flattenedArray.Length - 1 - i; j++)
                {
                    if (flattenedArray[j] > flattenedArray[j + 1])
                    {
                        int temp = flattenedArray[j];
                        flattenedArray[j] = flattenedArray[j + 1];
                        flattenedArray[j + 1] = temp;
                    }
                }
            }

            return $"Отсортированный массив: {string.Join(", ", flattenedArray)}";
        }

        private string SolveTask6()
        {
            int[,] matrix = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(0, 2);
                }
            }

            var firstRow = Enumerable.Range(0, 5).Select(j => matrix[0, j]).ToArray();
            int count = 0;

            for (int i = 1; i < 5; i++)
            {
                var currentRow = Enumerable.Range(0, 5).Select(j => matrix[i, j]).ToArray();
                if (currentRow.SequenceEqual(firstRow))
                {
                    count++;
                }
            }

            return $"Количество строк, похожих на первую: {count}";
        }

        private string SolveTask7()
        {
            int[,] matrix = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(0, 10);
                }
            }

            int k = 5;
            var positions = new List<(int, int)>();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] == k)
                    {
                        positions.Add((i, j));
                    }
                }
            }

            return $"Позиции элемента {k}: {string.Join(", ", positions)}";
        }

        private string SolveTask8()
        {
            int[,] matrix = new int[3, 3];
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                }
            }

            int minSum = int.MaxValue;
            int minRow = -1;

            for (int i = 0; i < 3; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < 3; j++)
                {
                    rowSum += matrix[i, j];
                }
                if (rowSum < minSum)
                {
                    minSum = rowSum;
                    minRow = i;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] *= minSum;
                }
            }

            return $"Матрица после умножения: {string.Join(", ", matrix.Cast<int>())}";
        }

        private string SolveTask9()
        {
            int[,] matrix = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                }
            }

            var lastElements = Enumerable.Range(0, 5).Select(i => matrix[i, 4]).ToArray();
            Array.Sort(lastElements);
            Array.Reverse(lastElements);

            return $"Последние элементы строк в порядке невозрастания: {string.Join(", ", lastElements)}";
        }

        private string SolveTask10()
        {
            int[,] matrix = new int[5, 10];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                }
            }

            int count = 0;
            for (int j = 0; j < 10; j++)
            {
                bool isDecreasing = true;
                for (int i = 1; i < 5; i++)
                {
                    if (matrix[i, j] >= matrix[i - 1, j])
                    {
                        isDecreasing = false;
                        break;
                    }
                }
                if (isDecreasing)
                {
                    count++;
                }
            }

            return $"Количество монотонно убывающих столбцов: {count}";
        }

        private string SolveTask11()
        {
            int[,] matrix = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                }
            }

            var minElements = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                int min = matrix[i, 0];
                for (int j = 1; j < 5; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
                minElements.Add(min);
            }

            int maxMin = minElements.Max();
            return $"Максимальный из минимальных элементов строк: {maxMin}";
        }

        private string SolveTask12()
        {
            int[,] matrix = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                }
            }

            int maxElement = 0;
            for (int j = 0; j < 5; j++)
            {
                bool isIncreasing = true;
                bool isDecreasing = true;
                for (int i = 1; i < 5; i++)
                {
                    if (matrix[i, j] <= matrix[i - 1, j])
                    {
                        isIncreasing = false;
                    }
                    if (matrix[i, j] >= matrix[i - 1, j])
                    {
                        isDecreasing = false;
                    }
                }
                if (isIncreasing || isDecreasing)
                {
                    int currentMax = Enumerable.Range(0, 5).Select(i => matrix[i, j]).Max();
                    if (currentMax > maxElement)
                    {
                        maxElement = currentMax;
                    }
                }
            }

            return $"Максимальный элемент в упорядоченных столбцах: {maxElement}";
        }

        private string SolveTask13()
        {
            int[,] matrix = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5 - i; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[4 - j, 4 - i];
                    matrix[4 - j, 4 - i] = temp;
                }
            }

            return $"Матрица после отражения: {string.Join(", ", matrix.Cast<int>())}";
        }

        private string SolveTask14()
        {
            int[,] matrix = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                }
            }

            var uniqueElements = new HashSet<int>();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    uniqueElements.Add(matrix[i, j]);
                }
            }

            return $"Уникальные элементы матрицы: {string.Join(", ", uniqueElements)}";
        }

        private string SolveTask15()
        {
            int[,] matrix = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                }
            }

            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += matrix[i, i];
            }

            return $"Сумма элементов главной диагонали: {sum}";
        }

        private string SolveTask16()
        {
            int[,] matrix = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                }
            }

            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += matrix[i, 4 - i];
            }

            return $"Сумма элементов побочной диагонали: {sum}";
        }

        private string SolveTask17()
        {
            int[,] matrix = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                }
            }

            int maxElement = matrix.Cast<int>().Max();
            return $"Максимальный элемент матрицы: {maxElement}";
        }

        private string SolveTask18()
        {
            int[,] matrix = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                }
            }

            int minElement = matrix.Cast<int>().Min();
            return $"Минимальный элемент матрицы: {minElement}";
        }

        private string SolveTask19()
        {
            int[,] matrix = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                }
            }

            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    sum += matrix[i, j];
                }
            }

            return $"Сумма всех элементов матрицы: {sum}";
        }

        private string SolveTask20()
        {
            int[,] matrix = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                }
            }

            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        count++;
                    }
                }
            }

            return $"Количество четных элементов: {count}";
        }
    }
}