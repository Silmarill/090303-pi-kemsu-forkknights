
using System;
using System.Collections.Generic;

namespace ForkKnights.Group2 {

  public class Nesterov : IKnight {
    public string Name;
    public string Profession { get; set; }
    public int Age;
    public bool Married;
    public List<string> FavoriteColor;

    public Nesterov() {

      Name = "Даня";
      Profession = "Программист";

      Age = 21;
      Married = false;

      FavoriteColor = new List<string> { "Blue", "Purple", "Black" };
      FavoriteColor.Add("White");
    }

    public string GetJobApplication() {

      string marriedText = Married ? "женат" : "холост";

      string JobApplicationText =
      $@"Приветули, я {Name}, {Age} год, {marriedText}, " +
      $@"люблю поиграть в видеоигры, пить 🌕, есть ☄️  и спать 🌌 ), " +
      $@"а ещё я {Profession} 🙏. " +
      "Я так же очень добрый. Наверное 😈";

      return JobApplicationText;
    }
  }
}