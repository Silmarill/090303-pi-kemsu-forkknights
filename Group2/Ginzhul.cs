using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForkKnights.Group2 {
  public class Ginzhul : IKnight {
    public string Archetype { get; set; }
    public string Name;
    public int DataFragments;
    public double PacketLossRate;
    public bool IsTangible;

    public Ginzhul() {
      Archetype = "Cyber Wraith";
      Name = "Призрак-0";
      DataFragments = 12843;
      PacketLossRate = 0.087;
      IsTangible = false;
    }
    public string GetJobApplication() {
      string tangibleText = IsTangible ? "могу трогать вещи" : "руки проходят сквозь всё, даже сквозь кнопки лифта";

      string JobApplicationText =
      $@"👻 Всем привет, я {Name}, {Archetype}. {tangibleText}. " +
      $@"💾 В моей памяти {DataFragments} чужих файлов, и я не все из них просили хранить. " +
      $@"🌐 Могу пройти сквозь любой файервол, если там есть дыра размером с пакет. " +
      $@"📡 Но иногда зависаю — с вероятностью {PacketLossRate:P0}. " +
      $@"😵 Это как икота, только цифровая. В такие моменты я вижу овец. 🐑 Они кивают. " +
      $@"🤔 Я не знаю, что это значит. 💼 Ищу работу, где не будут спрашивать, почему у меня нет " +
      $@"отпечатков пальцев. 🖐️🚫 Оплата — сегментами памяти или просто чтобы меня не выкидывали " +
      $@"из сети, когда я смотрю на овец. 🐏✨";

      return JobApplicationText;
    }
  }
}