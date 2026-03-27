using ForkKnights;

namespace ForkKnights.Group1 {
  public class Artur : IKnight {
    public string Name;
    public int Experience;

    public string ship;
    public string Rank;
    public string Treasure;   

    public Artur() {
      Name = "Артур";
      Experience = 10;
      ship = "Судно, спортивная лодка, парусная яхта, катер, крейсер";
      Rank = "Капитан дальнего плавания";
      Treasure = "Золотые слитки и редкие карты";
    }

    public string GetJobApplication() {
      return
      "Эй! Капитан ищет команду!\n" +
      "\n" +
      "Меня зовут " + Name + ".\n" +
      "Стаж плавания: " + Experience + " лет.\n" +
      "Звание: " + Rank + ".\n" +
      "На чём обычно плаваю: " + ship + ".\n" +
      "Любимая добыча: " + Treasure + ".\n" +
      "\n" +
      "Что умею:\n" +
      "- Вести корабль сквозь штормы\n" +
      "- Находить сокровища\n" +
      "- Делить добычу с командой\n" +
      "\n" +
      "Ищу капитана, который ценит лучших.\n" +
      "Готов поднять паруса в любой момент.\n";
    }
  }
}