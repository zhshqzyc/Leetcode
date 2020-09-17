 class Program
    {
        public enum Direction
        {
            GoingRight= 0,
            GoingDown = 1,
            GoingLeft = 2,
            GoingUp = 3
        }
        static void Main(string[] args)
        {
            int[][] matrix = new int[3][];
            matrix[0] = new int[3] { 1, 2, 3 };
            matrix[1] = new int[3] { 4, 5, 6 };
            matrix[2] = new int[3] { 7, 8, 9 };
            var result = SpiralOrder(matrix);
        }
        static IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> res = new List<int>();
            if (matrix != null && matrix.Length > 0 && matrix[0].Length > 0)
            {
                int rows = matrix.Length;
                int cols = matrix[0].Length;

                int left = 0, right = cols - 1, top = 0, bottom = rows - 1, direction = (int)Direction.GoingRight;
                while (left <= right && top <= bottom)
                {
                    if (direction == (int)Direction.GoingRight)
                    {
                        //Left to right
                        for (int i = left; i <= right; i++)
                        {
                            res.Add(matrix[top][i]);
                        }
                        top++;
                        direction = (int)Direction.GoingDown;
                    }
                    else if (direction == (int)Direction.GoingDown)
                    {
                        //top to bottom
                        for (int i = top; i <= bottom; i++)
                        {
                            res.Add(matrix[i][right]);
                        }
                        right--;
                        direction = (int)Direction.GoingLeft;
                    }
                    else if (direction == (int)Direction.GoingLeft)
                    {
                        //right to left
                        for (int i = right; i >= left; i--)
                        {
                            res.Add(matrix[bottom][i]);
                        }
                        bottom--;
                        direction = (int)Direction.GoingUp;
                    }
                    else if (direction == (int)Direction.GoingUp)
                    {
                        //bottom to top
                        for (int i = bottom; i >= top; i--)
                        {
                            res.Add(matrix[i][left]);
                        }
                        left++;
                        direction = (int)Direction.GoingRight;
                    }
                }
            }
            return res;
        }
    }
