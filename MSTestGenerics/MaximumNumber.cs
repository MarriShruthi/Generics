using System;

namespace MSTestGenerics
{
    internal class MaximumNumber
    {
        internal static string StringMaximumNumber(string S1, string S2, string S3) //static method
        {
            if (S1.CompareTo(S2) > 0 && S1.CompareTo(S3) > 0)
            {
                return S1;
            }
            if (S2.CompareTo(S1) > 0 && S2.CompareTo(S3) > 0)
            {
                return S2;
            }
            if (S3.CompareTo(S1) > 0 && S3.CompareTo(S2) > 0)
            {
                return S3;
            }
            throw new Exception("S1,S2,S3 are Same ");
        }
    }
}