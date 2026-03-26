using System;
using System.Collections.Generic;

namespace ForkKnights.Group2 {

  public class Ungefug : IKnight {
    public string Archetype { get; set; }
    public string Name;
    public string Specialization;
    public string Lvl;
    public int LosingHiil;
    public int WinHiil;
    public bool HasLicense;

    public Ungefug() {
      Archetype = "Cyber priest";
      HasLicense = true;

      Name = "Батюшка";
      Specialization = "просвещение";
      Lvl = "∞";
      LosingHiil = 1;
      WinHiil = 99;
    }

    public string GetJobApplication() {

      // Никогда не используйте тернарный оператор.
      string licenseText = HasLicense ? "есть лицензия" : "возьмите талончик потом поговорим";

      // почему где-то есть $@, а где-то нет??? и зачем @?
      // изучите что такое вребатимные строки и интерполяция
      string JobApplicationText =
      $@" Здравствуй, я сын божий {Name}, {Archetype} ({licenseText})," +
      $@"моя специализация и мое умение это - {Specialization}. Мои характеристики просты: Уровень контакта с богом {Lvl} Уровня " +
      $@"Шанс неудачного хилла святой водой {WinHiil}%, а процент успеха {LosingHiil}%" +
      " работаю за копейки, чтобы не грабить честной народ " +
      " если у вас нет денег можете отработать у церкви " +
      " Всех с наступающей пасхой! Заглядывайте к нам " +
      " Ночью сплю с просьбами изгнать нечистую силу не звонить! " +
      " Цель распространить хрестиантсво по всему миру ";

      return JobApplicationText;
    }
  }
}
