using System.Collections.Generic;
using System.Text;

public static class Words
{
    public static string CountCharactersInSentence(string inputString)

    {
        string New_inputString = inputString;

        string print = "";


        New_inputString = New_inputString.Replace(" ", string.Empty);

        while (New_inputString != "")


        {
            char characters = New_inputString[0];

            int Repeats = 1;

            for (int j = 1; j < New_inputString.Length; j++)

            {
                if (New_inputString[j] == characters)

                {
                    Repeats++;
                }
            }
            print += " " + characters + " : " + Repeats + " ";

            New_inputString = New_inputString.Replace(new String(characters, 1), string.Empty);
        }
        return print;
    }
}

