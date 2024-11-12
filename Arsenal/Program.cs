using System.Text.Json;

// Weapon w = new Weapon() {Name = "grej"};
// string json = JsonSerializer.Serialize<Weapon>(w);
// File.WriteAllText("Weapon.json", json);

string contents = File.ReadAllText("Weapon.json");

Weapon w = JsonSerializer.Deserialize<Weapon>(contents);

Console.WriteLine("How many attacks do you want to inflict?");

int numAttacks = 0;
string numAttacksStr  = "";

while(!int.TryParse(numAttacksStr, out numAttacks))
{
    numAttacksStr = Console.ReadLine();
}

int damageSum = 0;

Console.ForegroundColor = ConsoleColor.Red;

for (int i = 0; i < numAttacks; i++)
{
    int damage = w.Attack();
    Console.WriteLine($"+{damage}");
    damageSum += damage;
}

Console.ResetColor();

Console.WriteLine($"You did a total damage of {damageSum} points of damage!");

Console.ReadLine();
