using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ForkKnights.Group1 {
  public class Bobkova : IKnight {
    public string Archetype { get; set; }
    public string Name;
    public int Age;
    public int Height;
    public bool isAlive;
    public string aliveText;
    public int profExp;
    public string prevJob;
    public List<string> whatCanIDo;

    public Bobkova() {
      Archetype = "Человек";
      Name = "Гендальф";
      Age = 2100;
      Height = 170;
      isAlive = true;
      profExp = 2000;
      prevJob = "Маг";
      whatCanIDo = new List<string>() { "кастовать заклинания, ", "сражаться с Балрогами, ", "давать мудрые советы, ", "исчезать в нужный момент, ", "приходить ровно тогда, когда надо" };

      if (isAlive) {
        aliveText = "Да";
      } else {
        aliveText = "Нет";
      }
    }

    public string GetJobApplication() {

      var lines = new List<string>();

       foreach (var action in whatCanIDo) {
        lines.Add($"{action}");
       }

      string skills = string.Join("", lines);

      string JobApplicationText =
        $@"Привет, путник! 🧙‍♂️  
        Меня зовут {Name}, и, как ни странно, я всё ещё числюсь как {Archetype} — хотя после {Age} лет начинаешь сомневаться 😄  

        Мой рост — {Height} см, чтобы было удобнее смотреть на хоббитов сверху вниз 👀  
        Состояние: {(isAlive ? "жив, бодр и полон магии ✨" : "ну... это долгая история 👻")}  

         За плечами у меня уже {profExp} лет опыта — да, я не просто так ношу эту шляпу 🎩  
         Раньше подрабатывал как {prevJob}, но, честно говоря, это было не просто работой, а образом жизни 🔮  

         Я могу {skills}.🤔  

         Но если говорить по-настоящему...  
         Я тот, кто появляется ровно тогда, когда надежда почти угасла 🌌  
         Тот, кто может зажечь свет во тьме — или хотя бы костёр 🔥  

         Так что если тебе нужен кто-то в дорогу, в бой или просто за советом —  
         ты знаешь, кого звать 😉

         И помни...  
         ""You shall not pass!"" 🚫"; ;

      return JobApplicationText;
    }
  }
}
