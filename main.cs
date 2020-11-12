using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine(Reverse("H"));
  }

  public static string Reverse(string input){
    if(input == null || input.Length < 2 || input is string){
      return " Something is wrong";
    }
    
    char[] charArray = input.ToCharArray();
    char[] tempArray = new char[charArray.Length];

    for(int i = 0; i < charArray.Length ; i++ ){
      tempArray[i] = charArray[charArray.Length-1 - i]; 
    }

    string result = new string(tempArray);
    return result;

  }
}