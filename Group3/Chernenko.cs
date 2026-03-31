using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForkKnights.Group1 {
  internal class Chernenko : IKnight {
    public int healthPoints;
    public string name;
    public string specialization { get; set; }
    public int manaPoints;
    public int damage;
    public int age;
    public string weapon { get; set; }
    public string element { get; set; }

    public Chernenko() {
      healthPoints = 120;
      name = "Северный Вихрь";
      specialization = "Друид Севера";
      manaPoints = 200;
      damage = 55;
      age = 847;
      weapon = "Посох Ледяного Древа";
      element = "Лёд и Ветер";
    }

    public string GetJobApplication() {
      string jobAnnouncement;

      jobAnnouncement = "";

      return jobAnnouncement;
    }
  }
}
