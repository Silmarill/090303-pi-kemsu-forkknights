using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForkKnights.Group1 {
  internal class Smushkov : IKnight {

    public string Archetype { get; set; }
    public string Name;
    public string Specialization;
    public double EmotionalPenetrationPower;
    public int NeuralInterfaceVersion;
    public bool HasLicense;
    public List<string> TraumaticMemoriesDeleted;
    public List<string> EmotionalAnomalies;

    public Smushkov() {

      Archetype = "Эмпатический хакер";
      Name = "Нейромант-2077";
      Specialization = "ментальная кибербезопасность, эмоциональная диагностика, терапия кибертравм";
      EmotionalPenetrationPower = 97.3;
      NeuralInterfaceVersion = 8;
      HasLicense = true;

      TraumaticMemoriesDeleted = new List<string> {
        "Корпоративный инцидент Arasaka (251 сотрудник)",
        "ПТСР после атаки киберпсихопатов",
        "Фантомные боли после замены конечностей",
        "Эмоциональная блокировка из-за потери близкого"
      };

      EmotionalAnomalies = new List<string> {
        "Искусственная любовь через имплант",
        "Гнев, подсаженный через нейросеть",
        "Депрессия как корпоративный вирус",
        "Синдром множественных личностей (результат неудачного апгрейда)"
      };
    }

    public string GetJobApplication() {

      string licenseStatus;
      if (HasLicense) {
        licenseStatus = "ЛИЦЕНЗИРОВАН";
      } else {
        licenseStatus = "В ПРОЦЕССЕ ЛИЦЕНЗИРОВАНИЯ";
      }

      string jobApplication =
      $@"🧬 Всем привет, я {Name}, эмпатический хакер ({licenseStatus}) на взлом эмоций и воспоминаний, " +
      $@"специализируюсь на {Specialization} 🧠💔 Мои способности: чтение истинных чувств через нейроинтерфейс " +
      $@"(сейчас версия v{NeuralInterfaceVersion}.0), эмоциональное проникновение с точностью до {EmotionalPenetrationPower}%, " +
      $@"удаление травматических воспоминаний (всего удалено: {TraumaticMemoriesDeleted.Count} случаев), а также " +
      $@"полная ментальная диагностика, если клиент подпишет нужные бумаги 📜⚡ Ищу работу в корпорации или частном секторе: " +
      $@"готов вести внутренние расследования, проверять сотрудников на лояльность, консультировать по вопросам " +
      $@"киберпсихологии и ментальной безопасности 🤖🧠 Из сильных сторон — эмпатия, профессионализм и умение отличать " +
      $@"искренние эмоции от программного кода 😎 Слабые стороны — иногда слишком глубоко погружаюсь в чужие воспоминания, " +
      $@"забываю вовремя перезагружать нейроинтерфейс (а он сейчас на версии v{NeuralInterfaceVersion}.0, между прочим), " +
      $@"и панически боюсь зеркал после случая с альтернативной личностью клиента 🪞💥 Готов к работе в любом часовом поясе, " +
      $@"оплата — еврокредитами или новыми нейросетевыми прошивками, в идеале — и тем, и другим.";

      return jobApplication;
    }

  }
}
