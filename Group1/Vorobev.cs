using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ForkKnights.Group1 {
  public class Vorobev : IKnight {
    public string Archetype { get; set; }
    public string Name;
    public string Specialization;
    public double AccuracyRate;
    public int NeuroDeckCharge;
    public bool IsKind;
    public string License;

    public Vorobev() {

      Archetype = "Analog grandfather";
      IsKind = false;
      License = "Лицензии? Схожу — получу. Когда-нибудь";
      Name = "Борисыч";
      Specialization = "Сварщик 7-го разряда, Челябинский тракторный.";
      AccuracyRate = 1.01;
      NeuroDeckCharge = 0;
    }
    public string GetJobApplication() {
      string isKindText;

      if (!IsKind) {
        isKindText = "Настроение - стандартное, недовольное.";
      } else {
        isKindText = "Настроение - позитивное. Видимо произошла ошибка. Проверьте систему на наличие вирусов.";
      }

      string JobApplicationText;

      JobApplicationText = $@"🔧 {Name}. {Archetype}. {isKindText}" +
      $@"Специализаци: {Specialization}. Стрелю — {AccuracyRate}%, чтоб сосед не лез в огород." +
      $@"Лицензии: {License}." +
      $@"Умею: варить гвоздём. Без руки. Пальцы - 5 из 10." +
      $@"Нейрочип на {NeuroDeckCharge}% — на заводе не выдали такого." +
      $@"Ищу: охранять дачу. Сопровождать груз. Варить трубы. Оплата — наличкой, рублями. Сигареты — «Беломор» или «Прима». Обед — как поел, так и обед." +
      $@"P.S. Нет меня три дня — запой. Деньги под банку с рассадой. Нет банки — посадите сначала." +
      $@"Всё. Сказал. Пойду курну.";

      return JobApplicationText;
    }
  }
}
