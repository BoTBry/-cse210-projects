using System;
using System.Collections.Generic;

class Comments
{
    private List<string> commentList = new List<string>{};
    private List<string> commentName = new List<string>{};

    
    public void Comment(string _name, string _addcomment)
    {
        commentList.Add(_addcomment);
        commentName.Add(_name);

    }
    public void DisplayNumComments()
    {
        int Total = 0;
        for (int counter = 0; counter < commentName.Count; counter++)
        {
            Total++;
            Console.WriteLine($"{commentName[counter]}: \n{commentList[counter]}");
            Console.WriteLine();
        }
        Console.WriteLine($"Total comments: {Total}");

    }
}