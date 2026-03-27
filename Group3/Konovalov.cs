using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ForkKnights.Group3 {
  public class Konovalov : IKnight {
    string name, power, fromUniverse, species, status;
    int age;
    bool isHeAHero;

  public Konovalov() {
      name = "Сифил Лифисов";
      power = "Изначально был рождён с очень сильной магией огня, из-за чего сошёл с ума";
      fromUniverse = "Выходец из вселенной, в которой правят драконы и царит средневековье";
      species = "Человек, рождённый в сливянии дракона и человека";
      status = "Является выходцем из богатой семьи";
      age = 150;
      isHeAHero = false;
    }

    public string GetJobApplication() {
      string background = $@"Он был рождён во времена драконов,{name}";
      return background;
    }
  }
}
