using System;
using System.Collections.Generic;

namespace ForkKnights.Group2 {

  public class Ungefug : IKnight {
    public string Archetype { get; set; }
    public string Name;
    public string Specialization;
    public string Lvl;
    public int Losing;
    public int Win;
    public bool HasLicense;

    public Ungefug() {
      Archetype = "Cyber priest";
      HasLicense = true;

      Name = "Батюшка";
      Specialization = "просвещение";
      Lvl = "∞";
      Losing = 1;
      Win = 99;
    }

    public string GetJobApplication() {

      // Никогда не используйте тернарный оператор.
      string licenseText = HasLicense ? "есть лицензия" : "возьмите талончик потом поговорим";

      // почему где-то есть $@, а где-то нет??? и зачем @?
      // изучите что такое вребатимные строки и интерполяция
      string JobApplicationText =
      $@" Здравствуй, я сын божий {Name}, {Archetype} ({licenseText})," +
      $@"моя специализация и мое умение это - {Specialization}. Мои характеристики просты: Уровень контакта с богом {Lvl} Уровня " +
      $@"Шанс неудачного конатакта с богом {Win}%, а процент успеха {Losing}%" +
      " работаю за копейки, чтобы не грабить честной народ " +
      " если у вас нет денег можете отработать у церкви " +
      " Всех с наступающей пасхой! Заглядывайте к нам " +
      " Ночью сплю с просьбами изгнать нечистую силу не звонить! ";

      return JobApplicationText;
    }
  }
}
