// See https://aka.ms/new-console-template for more information

List<char> bokstäver = new List<char>(27);
char [] bokstäverArray = new char[]{'A', 'B', 'C', 'D', 'E', 'F','G','H','I','J', 'K','L','M','N','O','P', 'Q', 'R','S','T','U','V', 'W', 'X', 'Y', 'Z'};
for(int i = 0; i < bokstäverArray.Length; i++){
    bokstäver.Add(bokstäverArray[i]);
}

bool flag = true;
while(flag){
början(flag, bokstäver);
}

static void skrivaUt(List<char> bokstäver){
    System.Console.WriteLine(bokstäver);
}

static void ordInmatning(List<char> bokstäver){
Console.Write("Skriv in ditt ord här: ");
string ord = Console.ReadLine();
System.Console.WriteLine();
System.Console.WriteLine("Byt nu spelare!");
skrivaUt(bokstäver);
System.Console.Write("Bokstav: ");
char bokstav = char.Parse(Console.ReadLine());
if (bokstäver.Contains(bokstav)){

}

}

static void början(bool flag, List<char> bokstäver){
System.Console.WriteLine("Tryck 1 för att spela. Tryck 2 för att avsluta.");
int val = int.Parse(Console.ReadLine());
switch(val){
    case 1:
    ordInmatning(bokstäver);
    break;
    case 2:
    flag = false;
    break;
}


}