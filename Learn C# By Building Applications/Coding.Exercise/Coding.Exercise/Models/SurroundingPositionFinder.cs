using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Exercise.Models
{
    public class SurroundingPositionFinder
    {
        public List<int[]> FindSurroundingPositions(int[,] arr, int[] position)
        {
            List<int[]> result = new List<int[]>();
            try
            {
                if (IsValidPosition(arr, position))
                {
                    int x = position[0];
                    int y = position[1];
                    int[] upPosition = { x, y - 1 };
                    int[] rightPosition = { x + 1, y };
                    int[] leftPosition = { x - 1, y };
                    int[] downPosition = { x, y + 1 };
                    int[][] neighbourPositions = { upPosition, rightPosition, leftPosition, downPosition };

                    foreach (var pos in neighbourPositions)
                    {
                        if (IsValidPosition(arr, pos))
                        {
                            result.Add(pos);
                        }
                        continue;
                    }
                }
                else
                {
                    throw new ArgumentException("Invalid input. Please provide valid position");
                }
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }

        bool IsValidPosition(int[,] arr, int[] position)
        {
            bool isValid;
            if (position == null
                || position.Length != 2
                || position[0] >= arr.GetLength(0)
                || position[1] >= arr.GetLength(0)
                || position[0] < 0
                || position[1] < 0
                )
            {
                isValid = false;
            }
            else
            {
                isValid = true;
            }
            return isValid;
        }
    }
}
