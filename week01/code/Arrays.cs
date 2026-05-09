public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Create a new double array that has exactly 'length' spaces.
        // Use a loop to go through each index in the array.
        // For each index, calculate the multiple by multiplying 'number' by index + 1.
        // Store the calculated multiple in the array at the current index.
        // After the loop finishes, return the completed array.

        double[] multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Find the index where the last 'amount' numbers begin.
        // For example, if the list has 9 items and amount is 3,
        // the last 3 numbers begin at index 6.
        // Copy the last 'amount' numbers into a temporary list.
        // Remove those last 'amount' numbers from the original list.
        // Insert the temporary list at the beginning of the original list.
        // This modifies the original list instead of returning a new one.

        int startIndex = data.Count - amount;

        List<int> rotatedPart = data.GetRange(startIndex, amount);

        data.RemoveRange(startIndex, amount);

        data.InsertRange(0, rotatedPart);
    }
}
