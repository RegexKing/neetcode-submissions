public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;


        var aList = ToCountedDict(s);
        var bList = ToCountedDict(t);

        foreach(var kv in aList)
        {
            if (!bList.ContainsKey(kv.Key))
                return false;

            if (kv.Value != bList[kv.Key])
                return false;
        }

        return true;
    }

    private Dictionary<char, int> ToCountedDict(string s)
    {
        return s.GroupBy(x => x).ToDictionary(k => k.Key, v => v.Count());
    }
}
