using System;
using System.Collections.Generic;
using System.Net;

[Flags]
public enum Allergen
{
    Eggs = 1 << 0,
    Peanuts = 1 << 1,
    Shellfish = 1 << 2,
    Strawberries = 1 << 3,
    Tomatoes = 1 << 4,
    Chocolate = 1 << 5,
    Pollen = 1 << 6,
    Cats =  1 << 7
}

public class Allergies
{
    private Dictionary<Allergen, int> AllergenDictionary;
    private int maskValue;
    public Allergies(int mask)
    {
        AllergenDictionary = new Dictionary<Allergen, int>()
        {
            { Allergen.Eggs, 1},
            { Allergen.Peanuts, 2},
            { Allergen.Shellfish, 4},
            { Allergen.Strawberries, 8},
            { Allergen.Tomatoes, 16},
            { Allergen.Chocolate, 32},
            { Allergen.Pollen, 64},
            { Allergen.Cats, 128},
        };
        maskValue = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        //string mask2binary = Convert.ToString(maskValue, 2);
        var value = (int)allergen & maskValue;
        return value !=0? true : false;
    }

    public Allergen[] List()
    {
        var allgList = new List<Allergen>();
        foreach (var item in AllergenDictionary)
        {
            if ( IsAllergicTo(item.Key))
                allgList.Add(item.Key);
        }

        return allgList.ToArray();
    }
}