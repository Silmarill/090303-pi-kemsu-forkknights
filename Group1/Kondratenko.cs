using ForkKnights.Group1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForkKnights.Group1 {
  public interface IKnight {
    string GetJobAPPlication();
  }

  public class MyKnight : IKnight {
    public string Name;
    public string Universe;
    public int PowerLevel;
    public string FavorityColor;
    public int CoffeeDrunk;

    public MyKnight() {
      Name = "Генадий";
      Universe = "Чилл";
      PowerLevel = 142;
      FavorityColor = "Неоново фиолетовый";
      CoffeeDrunk = 5;
    }

    public string GetJobAPPlication() {
      return $"Приветствую грустные землянины, Меня зовут {Name}. " +
             $"Моя сила просто улёт: {PowerLevel}. " +
             $"Как у любых других людей, у меня есть 1-из любимых цветов {FavorityColor}. " +
             $"Много работаю и пью 5 {CoffeeDrunk}. " +
             $"Ищу кого то";
    }
  }
}

class Program 
  {
  static void Main() {
    MyKnight knight = new MyKnight();
    Console.WriteLine(knight.GetJobAPPlication());
  }
}
