// See https://aka.ms/new-console-template for more information

List<char> bokstäver = new List<char>(27);
char [] bokstäverArray = new char[]{'A', 'B', 'C', 'D', 'E', 'F','G','H','I','J', 'K','L','M','N','O','P', 'Q', 'R','S','T','U','V', 'W', 'X', 'Y', 'Z'};
for(int i = 0; i < bokstäverArray.Length; i++){
    bokstäver.Add(bokstäverArray[i]);
}
int liv = 10;
bool flag = true;
while(flag){
början(flag, bokstäver, liv);
}

static void skrivaUt(List<char> bokstäver){
    System.Console.WriteLine(bokstäver);
}

static void ordInmatning(List<char> bokstäver, bool flag, int liv){
Console.Write("Skriv in ditt ord här: ");
string ord = Console.ReadLine();
List<char> ordList = ord.ToList();
List<char> ordList2 = new List<char>(ordList);
System.Console.WriteLine();
System.Console.WriteLine("Byt nu spelare!");
bool flag2 = true;
while(flag2){
skrivaUt(bokstäver);
System.Console.Write("Bokstav: ");
char bokstav = char.Parse(Console.ReadLine());
if (bokstäver.Contains(bokstav)){
    if(ordList.Contains(bokstav)){
    bokstäver.Remove(bokstav);
    ordList.Remove(bokstav);
    System.Console.WriteLine("Finns i ordet!");
    if(ordList.Count == 0){
        System.Console.WriteLine("Bra jobbat!");
        foreach(char i in ordList2){
            System.Console.Write(i);
        }
        början(flag, bokstäver, liv);
    }
    }
    else{
        System.Console.WriteLine("Fel!");
        bokstäver.Remove(bokstav);
        liv --;
    }
}
else{
    System.Console.WriteLine("Redan gissad bokstav!");
}
}
}

static void början(bool flag, List<char> bokstäver, int liv){
System.Console.WriteLine("Tryck 1 för att spela. Tryck 2 för att avsluta.");
int val = int.Parse(Console.ReadLine());
switch(val){
    case 1:
    ordInmatning(bokstäver, flag, liv);
    break;
    case 2:
    flag = false;
    break;
}


}