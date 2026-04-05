using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForkKnights.Group2 {
  public class Stepanyan : IKnight {
    public string Name;
    public string Archetype;
    public string MainWeapon;
    public int ArmorIntegrity;
    public bool IsLookingForParty;

    public Stepanyan() {
      Name = "Сэр Степанян";
      Archetype = "Техно-Паладин";
      MainWeapon = "Квантовый Двуручник";
      ArmorIntegrity = 100;
      IsLookingForParty = true;
    }
  }
}
