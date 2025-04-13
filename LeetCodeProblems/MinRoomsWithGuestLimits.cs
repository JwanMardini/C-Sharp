/*
 * Given an array where each guest specifies the maximum number of people they are willing to share a room with, 
 * determine the minimum number of rooms needed so that no guest's preference is violated.
*/

using System;

public class MinRoomsWithGuestLimits
{
    public int solution(int[] A)
    {
        if (A.Length == 0) return 0;

        // Sort the array in descending order
        Array.Sort(A);
        Array.Reverse(A);

        List<int> rooms = new List<int>();

        foreach (int limit in A)
        {
            bool placed = false;
            for (int i = 0; i < rooms.Count; i++)
            {
                if (limit >= rooms[i] + 1)
                {
                    // Can add to this room
                    rooms[i]++;
                    placed = true;
                    break;
                }
            }
            if (!placed)
            {
                // Need a new room
                rooms.Add(1);
            }
        }

        return rooms.Count;
    }
}
