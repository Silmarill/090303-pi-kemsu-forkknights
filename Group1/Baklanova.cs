using System.Collections.Generic;

namespace ForkKnights.Group1 {
  public class Baklanova : IKnight {
    public string Archetype { get; set; }
    public string Name;
    public string BreathingStyle;
    public double IllusionPower;
    public double PerceptionRadius;
    public int CalmnessLevel;
    public int SwordSharpness;
    public int MentalFatigue;
    public List<string> DefeatedDemonsList;

    public Baklanova() {
      Archetype = "Corpse Illusionist";
      Name = "Haruto Tenmei";
      BreathingStyle = "Illusion Breathing";
      IllusionPower = 94.7;
      PerceptionRadius = 150.5;
      CalmnessLevel = 83;
      SwordSharpness = 100;
      MentalFatigue = 0;

      DefeatedDemonsList = new List<string> { "Kibutsu the Mirage", "Rokuro the Six-Eyed", "Yume the Dream Eater" };
      DefeatedDemonsList.Add("Phantom Demon from Shinano Province");
      DefeatedDemonsList.Add("Eleven Hallucinations of the Hell Gate");
    }

    public string GetJobApplication() {
      string JobApplicationText =
      $@"Вниманию кадрового отдела Корпуса.
      Меня зовут {Name}, я {Archetype}. Умею махать мечом ({SwordSharpness} из 100) и могу заставить демона сдаться, просто показав ему его страхи из прошлой жизни. Сила иллюзий — {IllusionPower}%, радиус чувствительности — {PerceptionRadius} метров. Спокойствие держится на {CalmnessLevel} баллах из 100, но коллеги почему-то называют это «странной привычкой смотреть в одну точку».
      Ментальная усталость — {MentalFatigue}. Побеждённых демонов в активе: {DefeatedDemonsList.Count}. Самые запомнившиеся: {string.Join(", ", DefeatedDemonsList)}.
      Что предлагаю:
      - Иллюзорные ловушки любой сложности
      - Психотерапию для особо упрямых демонов
      - Способность сохранять невозмутимость, даже когда вокруг всё горит
      От коллег требуется одно: не чихать рядом во время моей концентрации. Последствия могут быть неловкими для обеих сторон.
      Готов приступить хоть завтра. Оплата — чаем или тишиной.
      С уважением,
      {Name}";


      return JobApplicationText;
    }
  }
}
