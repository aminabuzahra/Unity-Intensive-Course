using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
   public string name = "";
   public int health = 100;

   public int playerExperience
   {
      get; 
      set;
   }


   void ChangeName(string playerName)
   {
      name = playerName;
   }

   public string PlayerName()
   {
      return name;
   }

   public void GetDamage(int value)
   {
       health = health - value;
   }

   public int HealthAmount()
   {
    return health;
   }

   public void Heal(int value)
   {
      health = health + value;
   }

   public void SetPlayerExperience(int value)
   {
      playerExperience = value;
   }

   public int GetPlayerExperience()
   {
      return playerExperience;
   }

}

