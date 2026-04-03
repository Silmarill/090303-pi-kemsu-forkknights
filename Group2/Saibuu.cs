using System;
using System.Collections.Generic;

namespace ForkKnights.Group2 {

  public class Saibuu : IKnight {

    public string Name { get; set; }
    public int ToxicYield;
    public string VenomProtocol;
    public int ChemStorage;
    public double TargetResistance;
    public string LastIncident;
    public List<string> CompletedContracts;
    public bool IsStealthMode;

    public Saibuu() {
      Name = "Чылан";
      ToxicYield = 87;
      VenomProtocol = "Neural Meltdown v.3.7";
      ChemStorage = 340;
      TargetResistance = 0.12;
      LastIncident = "2077.03.15 — корпорация Arasaka, нейтрализация отдела безопасности";
      IsStealthMode = true;

      CompletedContracts = new List<string> {
        "BioChem Industries — ликвидация генной лаборатории",
        "Militech — тестирование протокола «Silent Fang»",
        "Night Corp — зачистка токсичного следа в районе Kabuki"
      };
      CompletedContracts.Add("Анонимный заказ — уничтожение утечки данных через нервный яд");
    }

    public string GetJobApplication() {
      string licenseText = IsStealthMode ? "активен режим скрытности" : "режим обнаружения (осторожно!)";

      string JobApplicationText =
      $@"🐍 Всем привет, я {Name}, химический диверсант ({licenseText}), специалист по точечной нейтрализации 🧪💀 Мой токсический потенциал: {ToxicYield}%, активный протокол: {VenomProtocol}, запас реагентов: {ChemStorage} мл, пробиваемость защиты: {(1 - TargetResistance) * 100}% сопротивления цели. Последний инцидент: {LastIncident}. Выполненные контракты: BioChem Industries, Militech, Night Corp, анонимный заказ. Разрабатываю нейротоксины, которые отключают кибер-импланты на молекулярном уровне, провожу тихие ликвидации, которые выглядят как естественная смерть или сбой системы, взламываю биометрические замки через потовые железы охраны, создаю химические ловушки с отсрочкой активации, маскирую следы пребывания. Из особенностей: моя кровь является биологическим оружием, ношу противогаз даже на свиданиях, храню реагенты с постоянной вентиляцией. Ищу работодателя, которому нужна тотальная ликвидация конкурентов без улик, тестирование корпоративных систем защиты с летальным исходом или консультации по биобезопасности с демонстрацией уязвимостей на живых примерах. Не работаю в открытую, не оставляю подписей и не даю интервью после выполнения контракта. Оплата — только крипто-электронными овцами или редкими био-имплантами. Я — ваш тихий яд в этом шумном городе. 🐍";

      return JobApplicationText;
    }
  }
}