using System;
using System.Runtime.CompilerServices;
public class Journal{
    public void Display(string dateText, List<string> userInput, List<string> userInput2){
        for (int i = 0; i < userInput.Count; i++) {
            Console.WriteLine($"Date: {dateText} - Promt: {userInput2[i]}");
            Console.WriteLine(userInput[i]);
            Console.WriteLine();
        }
    }
    public void Load(string fileName)
    {
        string fileContents = File.ReadAllText(fileName);
        Console.WriteLine(fileContents);
    }
    public void Save(string fileName, string dateText, List<string> inputList, List<string> userlist){
        using (StreamWriter outputFile = new StreamWriter(fileName)){
            for (int i = 0; i < inputList.Count; i++){
                outputFile.WriteLine($"Date: {dateText} - Prompt: {userlist[i]}");
                outputFile.WriteLine(inputList[i]);
                outputFile.WriteLine();
            }
        }
    }
}
