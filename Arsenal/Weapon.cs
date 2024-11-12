using System;
using System.Text.Json.Serialization;


public class Weapon
{
    [JsonInclude]
    public String Name;

    
    public int Attack()
    {
       return Random.Shared.Next(2,20);
    }

}
