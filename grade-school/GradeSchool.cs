using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private Dictionary<string, int> GradeSchoolDictionary = new Dictionary<string, int>();
    public void Add(string student, int grade)
    {
        GradeSchoolDictionary.Add(student, grade);
    }

    public IEnumerable<string> Roster()
    {
        return GradeSchoolDictionary.OrderBy(name => name.Value)
            .ThenBy(name => name.Key)
            .Select(name => name.Key);
    }

    public IEnumerable<string> Grade(int grade)
    {
         return GradeSchoolDictionary.Where(g => g.Value == grade)
                                    .OrderBy(g => g.Key)
                                    .Select(g => g.Key);
    }
}