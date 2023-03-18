/*You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.

Increment the large integer by one and return the resulting array of digits.*/

/*
Example I/O
Input: digits = [1,2,3]
Output: [1,2,4]
Explanation: The array represents the integer 123.
Incrementing by one gives 123 + 1 = 124.
Thus, the result should be [1,2,4].
*/
public class Solution {
   public int[] PlusOne(int[] digits)
        {
            var keepIncrementing = true;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (keepIncrementing)
                {

                    if (digits[i] + 1 > 9)
                    {
                        digits[i] = 0;
                    }
                    else
                    {
                        digits[i] += 1;
                        keepIncrementing = false;
                    }
                        
                }
            }

            if (digits[0] == 0)
            {
                int[] results = new int[digits.Length + 1];

                results[0] = 1;
                for (int i = 1; i < results.Length; i++)
                {
                    results[i] = digits[i - 1];
                }

                return results;

            }

            return digits;
        }
}
