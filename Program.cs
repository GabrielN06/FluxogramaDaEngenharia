Console.WriteLine("--- Fluxograma da Engenharia ---");

Console.Write("\nO objeto está se movendo (S/N)? ");
string movendo = Console.ReadLine()!.ToUpper();

Console.Write("Deveria? ");
string deveria = Console.ReadLine()!.ToUpper();

if(movendo == "N" && deveria == "S"){
    Console.WriteLine("\nUse WD-40.");

}
else if (movendo == "S" && deveria =="N")
  {
      Console.WriteLine("\nUse Silver Tape.");
}
else if (movendo == "N" && deveria == "N"){
    Console.WriteLine("\nÓtimo!");
}
else if(movendo == "S" && deveria == "S"){
    Console.WriteLine("\nÓtimo!");
}
