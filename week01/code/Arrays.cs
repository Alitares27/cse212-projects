public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    /// 
    public static double[] MultiplesOf(double number, int length)
    {
        // Create a new array to hold the multiples with the size of 'length'
        var result = new double[length];

        // Loop from 0 to length-1 to calculate multiples
        for (int i = 0; i < length; i++)
        {

            // Calculate the multiple and store it in the array
            result[i] = number * (i + 1);
        }

        // Return the array with the calculated multiples
        return result;
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
        // Adjust 'amount' so it does not exceed the size of the list
        amount = amount % data.Count;

        // Extract the last 'amount' elements that will be moved to the front
        var last = data.GetRange(data.Count - amount, amount);

        // Extract the first part of the list (elements before the last 'amount')
        var first = data.GetRange(0, data.Count - amount);

        // Clear the original list to prepare for reordering
        data.Clear();

        // Add the 'last' part first, which is the rotated tail
        data.AddRange(last);

        // Add the 'first' part after the tail to complete the rotation
        data.AddRange(first);
    }
}
