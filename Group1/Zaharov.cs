using System;
using System.Collections.Generic;

namespace ForkKnights.Group1 {
  public class Zaharov : IKnight {
    
    public string Archetype;
    public string Name;
    public string Specialization;
    public double AverageSpeed;
    public int SenseOfHumorLevel;
    public bool HasDrivingLicense;

    public Zaharov() {

      Archetype = "Межпланетный таксист";
      HasDrivingLicense = true;
      Name = "Макс Ферстеплер";
      Specialization = "довезу куда угодно, но не спрашивайте, в какую галактику";
      AverageSpeed = 1000.67;
      SenseOfHumorLevel = 5;
    }

    public string GetJobApplication() {

      string licenseText;

      if (HasDrivingLicense) {
        licenseText = "есть права категории «Галактика - G»";
      } else {
        licenseText = "права на ховербайк, но это не точно";
      }

      string JobApplicationText = $@"🚕✨ Всем привет! Я {Name}, межпланетный таксист ({licenseText}) с гравитационным ускорителем вместо сердца! 🌌🏎️" +
    $@" Моя фишка — {Specialization}. Разгоняюсь до {AverageSpeed} световых в час (спидометр зашкаливает, но мы не жалуемся) ⚡🌠" +
    $@" Уровень чувства юмора: {SenseOfHumorLevel} из 10 (это значит, что шутку про «поворотник» я оценю, но только один раз 😄). " +
    $@"Могу довезти вас через червоточину, обогнать корпоративный крейсер на вираже и даже найти планету, " +
    $@"на которой реально вкусный кофе ☕🪐 В салоне: нейро-медитации для пассажиров, антигравитационные кресла " +
    @"и строгий запрет на вопли «ты куда сел?!» во время гиперпрыжка 🤪 Из слабостей — иногда путаю Альфу Центавра с " +
    $@"Бетельгейзе (навигатор в отпуске), коллекционирую штрафы от галактической полиции за «излишне живописные траектории», " +
    @"и категорически отказываюсь везти пассажиров, которые слушают Макана в открытом космосе 🎵🚫 " +
    @"Готов к рейсам любой сложности, оплата — кредитами, впечатлениями или хотя бы хорошим отзывом на межгалактическом агрегаторе 🌟😎"; ;

      return JobApplicationText;
    }
  }
}
