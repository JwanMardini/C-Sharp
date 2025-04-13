/*
 * A robot moves on a grid based on instructions from a string (^, v, <, >).
 * Determine if the path drawn by the robot forms a single, closed rectangle — ending at the starting point and not crossing itself (except possibly at the start/end).
 */

using System;

namespace LeetCodeProblems;
public class RobotPathRectangleValidator
{
    private static Dictionary<char, int> movesCounter = new() {
            {'^', 0},
            {'v', 0},
            {'<', 0},
            {'>', 0}
    };

    public int Solution(string moves)
	{
		char[] chars = moves.ToCharArray();
        int x = 0;
        int y = 0;

        foreach (char move in chars)
        {
            switch (move)
            {
                case '^':
                    y++;
                    movesCounter['^']++;
                    break;
                case 'v':
                    y--;
                    movesCounter['v']++;
                    break;
                case '>':
                    x++;
                    movesCounter['>']++;
                    break;
                case '<':
                    x--;
                    movesCounter['<']++;
                    break;

            }
        }
        if (x == 0 && y == 0 && CheckRectangle())
        {
            return 1;
        }else
        {
            return 0;                                                                    
        }
        
	}

    private static bool CheckRectangle()
    {
        return movesCounter['^'] == movesCounter['v'] && movesCounter['<'] == movesCounter['>'];
    }
}
