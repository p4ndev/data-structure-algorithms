public static class Robot
{
    /// <summary>
    /// Time: O(n²), Space: O(1)
    /// </summary>
    /// <param name="grid">Where robots are able to move (next or previous)</param>
    /// <returns></returns>
    public static bool IsValidPath(int[][] grid)
    {
        if (grid.Length <= 1)
            return false;

        (int robots, int paths, int steps) total = (
            grid.Length,
            grid[0].Sum(),
            grid[0].Count()
        );

        (int paths, int steps) current = (0, 0);

        for (int g = 1; g < total.robots; g++)
        {
            current = (
                grid[g].Sum(),
                grid[g].Count()
            );

            if (current.paths != total.paths ||
                    current.steps != total.steps)
                        return false;
        }

        // Current and Next (Sliding window technique)
        for (int c = 0, n = 1; n < total.robots; c++, n++)
        {
            // Current step within a path
            for (int s = 0; s < total.steps; s++)
            {
                if (grid[c][s] == 0)
                    continue;                   // Failed fast

                int position = 1;               // Next position
                if (s == (total.steps - 1))     // Previous position
                    position *= -1;

                if (grid[c][s] == grid[n][s] ||                 // Edge case for the same robot position
                        grid[c][s] != grid[n][s + position])    // Check if next or previous robot position
                            return false;
            }
        }

        return true;
    }
}