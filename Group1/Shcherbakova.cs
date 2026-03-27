using ForkKnights;

namespace ForkKnights.Group1 {
  public class Artur : IKnight {
    public string Name;
    public int Experience;
    public string ship { get; set; }

    public Artur() {
      Name = "Артур";
      Experience = 10;
      ship = "Судно, спортивная лодка,парусная яхта, катер, крейсер";
    }

    public string GetJobApplication() {
      return
      "Эй! Капитан ищет команду!\n" +
      "\n" +
      "Меня зовут " + Name + ".\n" +
      "Стаж плавания: " + Experience + " лет.\n" +
      "На чём обычно плаваю: " + ship + ".\n" +
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