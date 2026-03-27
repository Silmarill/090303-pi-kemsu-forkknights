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
      Archetype = "Скибиди туалет";
      Name = "Скибиди Вапапапич";
      Age = 1337;
      Height = 200;
      isAlive = true;
      profExp = 10;
      prevJob = "Вояка";
      whatCanIDo = new List<string>() {"ходить", "бродить", "гулять", "бежать", "приседать"};

      if (isAlive) {
        aliveText = "Да";
      } else {
        aliveText = "Нет";
      }

    }

    public string GetJobApplication() {

      string JobApplicationText = "";

      return JobApplicationText;


    }

  }
}
