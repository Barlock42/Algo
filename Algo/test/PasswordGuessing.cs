using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var digitNumber = Int32.Parse(Console.ReadLine());
        var forbPosition = Console.ReadLine();

        var forbPositionArray = forbPosition.Split(' ');

        var digitDict = new Dictionary<int, int>();
        for (int i = 0; i < 10; i++)
        {
            var digit = int.Parse(forbPositionArray[i]);
            if (digit > 0) digitDict.Add(i, digit);
        }

        Console.WriteLine(GeneratePasswords(digitNumber, digitDict));
    }

    static int GeneratePasswords(int digitNumber, Dictionary<int, int> digitDict)
    {
        var resultPasswords = new List<string>();
        GeneratePasswordsRecursive(digitNumber, digitDict, 0, resultPasswords, new char[digitNumber]);
        return resultPasswords.Count();
    }

    static void GeneratePasswordsRecursive(int digitNumber, Dictionary<int, int> digitDict, int curPosition, List<string> resultPasswords, char[] curPassword)
    {
        var isValid = true;
        foreach (var existingDigit in digitDict)
        {
            var digit = existingDigit.Key;
            var isKeyPresent = false;

            foreach (char c in curPassword)
            {
                if (c == digit)
                {
                    isKeyPresent = true;
                }
            }

            isValid = isValid && isKeyPresent;
        }

        if (curPosition == digitNumber && isValid)
        {
            resultPasswords.Add(new string(curPassword));
            return;
        }

        foreach (var existingDigit in digitDict)
        {
            var digit = existingDigit.Key;
            var lastPosition = existingDigit.Value;

            if (curPosition < lastPosition)
            {
                // Console.WriteLine(curPosition);
                curPassword[curPosition] = (char)digit;
                GeneratePasswordsRecursive(digitNumber, digitDict, curPosition + 1, resultPasswords, curPassword);
            }
        }
    }
}
