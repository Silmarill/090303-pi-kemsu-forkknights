using System;
using System.Collections.Generic;

namespace ForkKnights.GroupExample {

  public class VladilenPelmeniy : IKnight {
    public string Title { get; set; }
    public string Name;
    public string Universe;
    public int PowerLevel;
    public string FavoriteColor;
    public int CoffeeConsumed;
    public int PelmeniMastered;
    public List<string> SecretRecipes;
    public bool HasGoldenSpoon;

    public VladilenPelmeniy() {
      Title = "Властелин пельменей";
      Name = "Пельмень Великий";
      Universe = "Гастрономическая вселенная";
      PowerLevel = 100;
      FavoriteColor = "тесто-белый с мясным отливом";
      CoffeeConsumed = 39;
      PelmeniMastered = 420;
      HasGoldenSpoon = true;

      SecretRecipes = new List<string> {
        "С печенью и тайной",
        "Сибирский взрыв",
        "Пельмень бессмертия"
      };
      SecretRecipes.Add("С сюрпризом внутри");
    }

    public string GetJobApplication() {
      string spoonText = HasGoldenSpoon ? "есть золотая ложка 🥄✨" : "ложка в поиске";

      string JobApplicationText =
      $@"🥟 Всем привет, я {Name}, {Title} ({spoonText}) из {Universe}! 🌌🍽️
      
📜 Мои достижения: освоил {PelmeniMastered} рецептов пельменей, включая секретные: {string.Join(", ", SecretRecipes)}.
☕ Энергия поддерживается {CoffeeConsumed} чашками кофе в день (меньше нельзя — пельменный поток остановится).
💪 Уровень силы: {PowerLevel} единиц тестомеса (могу замесить {PowerLevel} кг теста за один подход).
🎨 Любимый цвет: {FavoriteColor} — классика, которая никогда не выходит из моды.

🔍 Ищу работу в кулинарном искусстве! 🧠✨ Готов:
• Возглавить пельменный департамент любой корпорации
• Разрабатывать инновационные начинки (даже те, что человечество ещё не готово принять)
• Обучать персонал искусству правильной лепки (30 пельменей в минуту — мой личный рекорд)
• Проводить дегустации с гарантией гастрономического просветления

⚡ Сильные стороны: идеальное соотношение теста и начинки, умение найти общий язык с любым тестом, способность съесть {PelmeniMastered} пельменей за один присест (это наука, а не обжорство!).
😅 Слабые стороны: иногда слишком увлекаюсь экспериментами (последний пельмень с шоколадом и селёдкой до сих пор вспоминают с ужасом), и панически боюсь закончившейся сметаны 🥛💔

🎯 Готов к работе в любой точке вселенной, оплата — пельменями или сметаной (в идеале — и тем, и другим). Золотая ложка уже при мне! 🥄👑";

      return JobApplicationText;
    }
  }
}