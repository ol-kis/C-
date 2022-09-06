Console.WriteLine("Hello, You are runnung my litlle App");
Console.WriteLine("Write some words");
string [] words= Console.ReadLine().Split(',');
string [] words_Length= new string[words.Length];
<<<<<<< Updated upstream:Hw.cs

=======
for (int i=0;i<words.Length;i++){
    if (words[i].Length<=3){
        Console.Write($"{words[i]} ");
        words_Length[i]=words[i];
    }
        }
        Console.WriteLine(); 
>>>>>>> Stashed changes:HW.cs

