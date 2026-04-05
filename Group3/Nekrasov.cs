using System;
using System.Collections.Generic;

namespace ForkKnights.GroupExample {

  public class Nerkasov : IKnight {
    public string Archetype { get; set; }
    public string Name;
    public string Specialization;
    public string LazyLvl;
    public int LazyChance;
    public int WorkEfficiency;
    public bool HasLicense;

    public Nerkasov() {

      Archetype = "Cyber Chel";
      HasLicense = true;

      Name = "Неан Тагонист";
      Specialization = "спать и спать";
      LazyLvl = "∞";
      LazyChance = 99;
      WorkEfficiency = 0;
    }

    public string GetJobApplication() {

      // Никогда не используйте тернарный оператор.
      string licenseText = HasLicense ? "есть лицензия" : "лицензия где-то прое... пропита";

      // почему где-то есть $@, а где-то нет??? и зачем @?
      // изучите что такое вребатимные строки и интерполяция
      string JobApplicationText =
      $@" Короче, я {Name}, {Archetype} ({licenseText})," +
      $@"моя специализация и главая супер сила это - {Specialization}. Мои характеристики просты: Уровень лени достигает {LazyLvl} Уровня " +
      $@"Шанс уснуть вместо работы составляет {LazyChance}%, а процент выполненой работы состовляет {WorkEfficiency}%" +
      " нужны деньги, желательно бесплатно, у меня дошик кончился " +
      " если у вас нет бесплатных деняг - лучше не пишите, я сам вас найду " +
      " Из сильных сторон — принципиальность, желание работать, бесконечная эффективность, лучший работник года " +
      " Слабые стороны - мне кровать дороже родины " +
      " НЕ готов к работе в любом часовом поясе, оплата — дошиками. ";

      return JobApplicationText;
    }
  }
}

