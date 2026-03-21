using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForkKnights {
  public interface IKnight {
    // возвращает объявление о работе: кто я, что умею, какие поручения ищу
    string GetJobApplication();
  }
}
