using System;
using System.Collections.Generic;
using System.Linq;

namespace StringPermutation.Libraries.StringPermutation
{
    public class StringPermutation
    {
        private List<string> permutations;
        private string permutationString;

        public List<string> Permutations { get{
            return permutations;
        }}

        public StringPermutation(string permutationString)
        {
            this.permutationString = new string (permutationString.Distinct().ToArray());
            this.permutations = new List<string>();
            this.permutation();
        }

        private void permutation()
        {
            permutation("", this.permutationString);
        }

        private void permutation(string perm, string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                this.permutations.Add(perm);
            }
            else
            {
                for( int i = 0; i < word.Length; i++)
                {
                    permutation(
                        perm + word[i], 
                        word.Length > 1 ? word.Remove(i, 1) : string.Empty
                    );
                }
            }
        }
    }
}
