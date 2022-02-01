using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotOnTheMars
{
    public class Mars
    {
        int x = 0;
        int y = 0;
        int LocationX = 1;
        int LocationY = 1;
        int[,] SurfaceMatrix;
        Directions Heading;
        InputEnum CurrentInput;
        public enum Directions
        {
            North = 0,
            West = 1,
            East = 2,
            South = 3

        }
        public enum InputEnum
        {
            L = 0,
            R = 1,
            F = 3
        }
        public Mars(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int[,] CreateTheMarsSurface()
        {
            SurfaceMatrix = new int[x, y];
            return SurfaceMatrix;

        }
        public int[,] getMarsMatrix()
        {
            return SurfaceMatrix;
        }
        public void Move(InputEnum Input)
        {

            try
            {
                //string TempInput = Input.ToUpper();
                CurrentInput = Input;

                if (CurrentInput == InputEnum.R)
                {
                    if (Heading == Directions.North)
                    {
                        if (LocationY < SurfaceMatrix.GetLength(1))
                        {
                            LocationY++;
                            Heading = Directions.East;
                        }


                    }
                    else if (Heading == Directions.West)
                    {
                        if (LocationX < SurfaceMatrix.GetLength(0))
                        {
                            LocationX++;
                            Heading = Directions.North;
                        }

                    }
                    else if (Heading == Directions.East)
                    {
                        if (LocationX > 1)
                        {
                            LocationX--;
                            Heading = Directions.South;
                        }

                    }
                    else if (Heading == Directions.South)
                    {
                        if (LocationY > 1)
                        {
                            LocationY--;
                            Heading = Directions.West;
                        }

                    }
                }
                else if (CurrentInput == InputEnum.L)
                {
                    if (Heading == Directions.North)
                    {
                        if (LocationY > 1)
                        {
                            LocationY--;
                            Heading = Directions.West;
                        }

                    }
                    else if (Heading == Directions.West)
                    {
                        if (LocationX > 1)
                        {
                            LocationX--;
                            Heading = Directions.South;
                        }

                    }
                    else if (Heading == Directions.East)
                    {
                        if (LocationX < SurfaceMatrix.GetLength(0))
                        {
                            LocationX++;
                            Heading = Directions.North;
                        }

                    }
                    else if (Heading == Directions.South)
                    {
                        if (LocationY < SurfaceMatrix.GetLength(1))
                        {
                            LocationY++;
                            Heading = Directions.East;
                        }

                    }
                }
                else if (CurrentInput == InputEnum.F)
                {
                    if (Heading == Directions.North)
                    {
                        if (LocationX < SurfaceMatrix.GetLength(0))
                        {
                            LocationX++;
                            Heading = Directions.North;
                        }

                    }
                    else if (Heading == Directions.West)
                    {
                        if (LocationY > 1)
                        {
                            LocationY--;
                            Heading = Directions.West;
                        }

                    }
                    else if (Heading == Directions.East)
                    {
                        if (LocationY < SurfaceMatrix.GetLength(1))
                        {
                            LocationY++;
                            Heading = Directions.East;
                        }

                    }
                    else if (Heading == Directions.South)
                    {
                        if (LocationX > 1)
                        {
                            LocationX--;
                            Heading = Directions.North;
                        }

                    }
                }

                Console.WriteLine("Heading: " + Heading);
                Console.WriteLine("x: " + LocationX);
                Console.WriteLine("y: " + LocationY);
            }
            catch (Exception ex)
            {

            }

        }
        public int getX()
        {
            return LocationX-1;
        }
        public int getY()
        {
            return LocationY-1;
        }

    }
}
