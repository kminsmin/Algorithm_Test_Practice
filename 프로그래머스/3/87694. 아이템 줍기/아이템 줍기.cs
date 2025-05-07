using System;
using System.Collections.Generic;
using Define;

public class Solution
{
    public bool IsOutline(int x, int y, int maxx, int maxy, int[,] map)
    {
        int[] dx = new int[] { -1, 1, 0, 0 };
        int[] dy = new int[] { 0, 0, -1, 1 };
        for (int w = 0; w < 4; w++)
        {
            int nx = x + dx[w];
            int ny = y + dy[w];
            if (nx < 0 || ny < 0 || nx > maxx || ny > maxy || map[nx, ny] == 0) return true;
        }
        return false;
    }
    public bool IsCorner(int x, int y, int maxx, int maxy, int[,] map)
    {
        int[] dx = new int[] { -1, 1, 0, 0 };
        int[] dy = new int[] { 0, 0, -1, 1 };
        int count = 0;
        for (int w = 0; w < 4; w++)
        {
            int nx = x + dx[w];
            int ny = y + dy[w];
            if (nx < 0 || ny < 0 || nx > maxx || ny > maxy || map[nx, ny] == 0) continue;
            else if (map[nx, ny] == -1) count++;
        }
        return (count==2&&map[x,y]==2)? true:false;
    }
    public int solution(int[,] rectangle, int characterX, int characterY, int itemX, int itemY)
    {
        int minx = int.MaxValue;
        int maxx = int.MinValue;
        int miny = int.MaxValue;
        int maxy = int.MinValue;
            for (int i = 0; i < rectangle.GetLength(0); i++)
{
    for (int j = 0; j < rectangle.GetLength(1); j++)
    {
        switch (j)
        {
            case 0:
                minx = (rectangle[i, j] < minx) ? rectangle[i, j] : minx;
                break;
            case 1:
                miny = (rectangle[i, j] < miny) ? rectangle[i, j] : miny;
                break;
            case 2:
                maxx = (rectangle[i, j] > maxx) ? rectangle[i, j] : maxx;
                break;
            case 3:
                maxy = (rectangle[i, j] > maxy) ? rectangle[i, j] : maxy;
                break;
        }
    }
}
        int ratio = 4;
minx *= ratio;
miny *= ratio;
maxx *= ratio;
maxy *= ratio;
maxx -= minx;
maxy -= miny;
int[,] map = new int[maxx + 1, maxy + 1];
//color all rectangle zones => all values 1~4. outline values 1,2
for (int i = 0; i < rectangle.GetLength(0); i++)
{
    for (int j = rectangle[i, 0]*ratio; j <= rectangle[i, 2]*ratio; j++)
    {
        for (int k = rectangle[i, 1]*ratio; k <= rectangle[i, 3] * ratio; k++)
        {
            map[j - minx, k - miny]++;
        }
    }
}
//check only outlines of rectangles => mark the final outlines by -1
int[] dx = new int[] { -1, 1, 0, 0 };
int[] dy = new int[] { 0, 0, -1, 1 };
for (int i = 0; i < rectangle.GetLength(0); i++)
{
    for (int j = rectangle[i, 0] * ratio; j <= rectangle[i, 2] * ratio; j++)
    {
        if (j == rectangle[i, 0]*ratio || j == rectangle[i, 2] * ratio)
        {
            for (int k = rectangle[i, 1] * ratio; k <= rectangle[i, 3]*ratio; k++)
            {
                if (IsOutline(j - minx, k - miny, maxx, maxy, map)) map[j - minx, k - miny] = -1;
            }
        }
        else
        {
            if (IsOutline(j - minx, rectangle[i,1]*ratio-miny,maxx,maxy,map)) map[j - minx, rectangle[i, 1]*ratio - miny] = -1;
            if (IsOutline(j - minx, rectangle[i, 3]*ratio - miny, maxx, maxy, map)) map[j - minx, rectangle[i, 3]*ratio - miny] = -1;
        }
    }
}

for (int i = 0; i < rectangle.GetLength(0); i++)
{
    for (int j = rectangle[i, 0] * ratio; j <= rectangle[i, 2]*ratio; j++)
    {
        if (j == rectangle[i, 0] * ratio || j == rectangle[i, 2] * ratio)
        {
            for (int k = rectangle[i, 1] * ratio; k <= rectangle[i, 3] * ratio; k++)
            {
                if (IsCorner(j - minx, k - miny, maxx, maxy, map)) map[j - minx, k - miny] = -1;
            }
        }
        else
        {
            if (IsCorner(j - minx, rectangle[i, 1]*ratio - miny, maxx, maxy, map)) map[j - minx, rectangle[i, 1]*ratio - miny] = -1;
            if (IsCorner(j - minx, rectangle[i, 3]*ratio - miny, maxx, maxy, map)) map[j - minx, rectangle[i, 3]*ratio - miny] = -1;
        }
    }
}
for (int i = maxy; i >= 0; i--)
{
    for (int j = 0; j <= maxx; j++)
    {
        if (map[j, i] == -1) Console.Write("* ");
        else Console.Write("- ");
    }
    Console.WriteLine();
}
for (int i = maxy; i >= 0; i--)
{
    for (int j = 0; j <= maxx; j++)
    {
        Console.Write(map[j, i].ToString() + " ");
    }
    Console.WriteLine();
}

//BFS
Queue<Coords> coordQueue = new Queue<Coords>();
bool[,] visitedCoord = new bool[maxx + 1, maxy + 1];
visitedCoord[characterX*ratio - minx, characterY*ratio - miny] = true;

coordQueue.Enqueue(new Coords(characterX*ratio - minx, characterY*ratio - miny, 0));
    while (coordQueue.Count > 0)
    {
        Coords currentCoord = coordQueue.Dequeue();
        for (int i = 0; i < 4; i++)
        {
            Coords tempCoord = currentCoord;
            tempCoord.X += dx[i];
            tempCoord.Y += dy[i];
            if (tempCoord.X >= 0 && tempCoord.Y >= 0 && tempCoord.X <= maxx && tempCoord.Y <= maxy && !visitedCoord[tempCoord.X, tempCoord.Y] && map[tempCoord.X, tempCoord.Y] == -1)
            {
                visitedCoord[tempCoord.X, tempCoord.Y] = true;
                tempCoord.minDistance = currentCoord.minDistance + 1;
                coordQueue.Enqueue(tempCoord);
                if (tempCoord.X == itemX*ratio-minx && tempCoord.Y == itemY*ratio-miny) return tempCoord.minDistance/ratio;
            }
        }
    }
    return 0;
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