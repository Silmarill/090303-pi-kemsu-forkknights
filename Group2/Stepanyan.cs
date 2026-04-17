using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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
      Name = "Чёрный мечник";
      Archetype = "Берсерк";
      MainWeapon = "Двуручный меч";
      ArmorIntegrity = 100;
      IsLookingForParty = true;
    }

    public string GetJobApplication() {
      string partyStatus;

      if (IsLookingForParty) {
        partyStatus = "ищу отряд для поиска Гриффита";
      }
      else {
        partyStatus = "уже имею команду, и я иду за Гриффитом";
      }

      // @ вставил чтобы не переносить вручную все строки
      return $@"Я - {Name}, класс: {Archetype}. 
       В моих руках {MainWeapon}. Целостность доспеха: {ArmorIntegrity}%. 
       Зря вы оставили меня недоеденным. Сейчас я {partyStatus}.";
    }
  }
}
