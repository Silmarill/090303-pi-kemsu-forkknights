using System;
using System.Collections.Generic;

namespace ForkKnights.GroupExample {

  public class Skachkov : IKnight {
    public string Archetype { get; set; }
    public string Name;
    public string Specialization;
    public double AccuracyRate;
    public double AmuletPower;
    public double SwordSwingForce;
    public double RollerAcceleration;
    public int BugsSlain;
    public bool HasLicense;
    public List<string> PastYearLicenseList;

    public Skachkov() {

      Archetype = "Bug Witcher";
      HasLicense = true;

      PastYearLicenseList = new List<string> { "1273", "1192", "1088" };
      PastYearLicenseList.Add("1050");
      Name = "Гринальд из Ривии";
      Specialization = "истребление баганых чудищ, отладка проклятого кода, ритуальная чистка репозиториев";
      AccuracyRate = 0.941;
      AmuletPower = 69.4;
      SwordSwingForce = 847.3;
      RollerAcceleration = 12.7;
      BugsSlain = 1337;
    }

    public string GetJobApplication() {

      string licenseText = HasLicense ? "лицензия Школы Баганого Волка" : "испытание багами еще не пройдено";

      string JobApplicationText =
      $"Всем привет, я {Name}, баганый ведьмак ({licenseText}) из Школы Баганого Волка," +
      $"специализируюсь на {Specialization}. Мои возможности: сила взмаха меча — {SwordSwingForce} Н," +
      "хватает чтобы разрубить даже самый запутанный спагетти-код, ускорение на роликах —" +
      $"{RollerAcceleration} м/с (догоню любой баг, а точность распознавания чудищ — {AccuracyRate:P1}" +
      $"Мой кибер-амулет заряжен на {AmuletPower}% — этого хватит чтобы наложить знак" +
      "«Аксель» (рывок на роликах) или знак «Артефакт» (исправление бага одним взглядом на" +
      $"стектрейс). За спиной {BugsSlain} поверженных баганых чудищ, включая трехголового Багарона, и стаю диких Багмышей." +
      "Из сильных сторон — феноменальная скорость на роликах, умение предсказывать баги по" +
      "запаху горячего процессора и принципиальность в бою (баг — значит баг, никакой" +
      "поблажки даже синтаксическим ошибкам). Слабые стороны — иногда так разгоняюсь на" +
      "роликах, что пролетаю мимо нужного коммита, панически боюсь резиновых уточек" +
      "(вдруг это отладчик прикидывается?), и могу случайно затереть прод, если слишком" +
      $"сильно взмахну мечом (было дело — {SwordSwingForce} Н не шутка)" +
      "Готов к работе в любом репозитории, оплата — редкими багами для коллекции или" +
      "новыми подшипниками для роликов, в идеале — и тем, и другим." +
      "P.S. Скачки на роликах по серверам — мой профиль, устрою шоу даже на деплое!";

      return JobApplicationText;
    }
  }
}

