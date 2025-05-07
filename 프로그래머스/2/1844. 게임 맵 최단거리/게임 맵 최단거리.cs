using System;
using System.Collections.Generic;
using Define;

class Solution
{
    public int solution(int[,] maps)
    {
        bool[,] visitedCoord = new bool[maps.GetLength(0), maps.GetLength(1)];
        Queue<Coords> coordQueue = new Queue<Coords>();
        Coords initCoord = new Coords(0, 0, 1);
        Coords targetCoord = new Coords(maps.GetLength(0) - 1, maps.GetLength(1) - 1, 0);
        int[] dy = new int[] { -1, 1, 0, 0 };
        int[] dx = new int[] { 0, 0, -1, 1 };
        visitedCoord[0, 0] = true;
        coordQueue.Enqueue(initCoord);
        while (coordQueue.Count > 0)
        {
            Coords currentCoord = coordQueue.Dequeue();
            for (int i = 0; i < 4; i++)
            {
                Coords tempCoord = currentCoord;
                tempCoord.X += dx[i];
                tempCoord.Y += dy[i];
                if (tempCoord.X < 0 || tempCoord.X > targetCoord.X || tempCoord.Y < 0 || tempCoord.Y > targetCoord.Y) continue;
                else if (maps[tempCoord.X, tempCoord.Y] == 0) continue;
                else if (visitedCoord[tempCoord.X, tempCoord.Y]) continue;
                else
                {
                    visitedCoord[tempCoord.X, tempCoord.Y] = true;
                    tempCoord.minDistance = currentCoord.minDistance + 1;
                    coordQueue.Enqueue(tempCoord);
                    if (tempCoord.X == targetCoord.X && tempCoord.Y == targetCoord.Y) return tempCoord.minDistance;
                }
            }
        }
        return -1;
    }
}
namespace Define
{
    public struct Coords
    {
        public int X;
        public int Y;
        public int minDistance;
        public Coords(int x, int y, int d)
        {
            X = x;
            Y = y;
            minDistance = d;
        }
    }
}
