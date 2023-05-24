using System;
namespace Algo
{
    public class Anagram
    {
        public IList<IList<string>> GroupAnagrams(string[] strs) {
        var result = new Dictionary<string, IList<string>>();
        foreach(var s in strs)
        {
            var hash = new char[26];
            foreach(var c in s)
            {
                hash[c - 'a']++;
            }

            var key = new string(hash);
            if (!result.ContainsKey(key)) {
                result[key] = new List<string>();
            }
            result[key].Add(s);
        }

        return result.Values.ToList();
    }
    }
}