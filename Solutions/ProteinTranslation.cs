// https://exercism.org/tracks/csharp/exercises/protein-translation

using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

public static class ProteinTranslation
{    
    static Dictionary<string, string> table = new Dictionary<string, string>()
    {
        {"AUG", "Methionine"},
        {"UUU UUC", "Phenylalanine"},
        {"UUA UUG", "Leucine"},
        {"UCU UCC UCA UCG", "Serine"},
        {"UAU UAC", "Tyrosine"},
        {"UGU UGC", "Cysteine"},
        {"UGG", "Tryptophan"},
    };
    static string[] codons = table.Keys.ToArray();
    static string stop = "UAA UAG UGA";
    
    private static string[] ParseStrand(string _strand)
    {
        List<string> strand = new List<string>();
        StringBuilder str = new StringBuilder();
        foreach(char c in _strand.ToCharArray())
        {
            str.Append(c);
            if(str.Length == 3)
            {
                if(stop.Contains(str.ToString()))
                    break;
                strand.Add(str.ToString());
                str.Clear();
            }
        }
        return strand.ToArray();
    }    
    public static string[] Proteins(string strand)
    {        
        List<string> res = new List<string>();
        string[] parsed = ParseStrand(strand);
        foreach(string codon in parsed)
        {
            foreach(string c in codons)
            {
                if(c.Contains(codon))
                    res.Add(table[c]);
            }
        }
        return res.ToArray();
    }
}
