using System;
using System.Collections.Generic;

namespace ForkKnights.Group3 {

  public class Nikitin : IKnight {
    public string Archetype { get; set; }
    public string Name;
    public string Specialization;
    public double AccuracyRate;
    public int NeuroDeckCharge;
    public bool HasLicense;
    public List<string> PastYearLicenseList;

    public Nikitin() {

      Archetype = "Изготовитель мыла";
      HasLicense = false; // Какие лицензии у Тайлера?

      PastYearLicenseList = new List<string> { "Бойцовский клуб", "Проект Разгром", "Бумажная стрит" };
      PastYearLicenseList.Add("Киномеханик");
      Name = "Тайлер Дерден";
      Specialization = "создание контролируемого хаоса и производство элитного мыла";
      AccuracyRate = 99.99;
      NeuroDeckCharge = 0;
    }

    public string GetJobApplication() {

      string licenseText = HasLicense ? "есть лицензия" : "лицензий не признаю, мы сами по себе";

      string JopApplicationText =
        $@"👊 Привет. Я {Name}, мой архетип — {Archetype} ({licenseText}). " +
        $@"Моя основная специализация — {Specialization}. 🧼" +
        $@"Мой заряд сна (NeuroDeckCharge) постоянно на {NeuroDeckCharge}%, потому что когда у тебя бессонница, всё кажется копией копии. 👁️" +
        $@"Точность попадания в челюсть при инициации новичков составляет {AccuracyRate}%. " +
        $@"Ищу работу в ночную смену: киномехаником или официантом в дорогом ресторане. " +
        $@"Первое правило: не задавать лишних вопросов. Нанимайте меня, пока мы не обнулили вашу кредитную историю. 😎";

      return JopApplicationText;
    }
  }
}
