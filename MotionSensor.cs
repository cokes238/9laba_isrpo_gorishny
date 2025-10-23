using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9laba_isrpo_gorishny
{
   
    public delegate void MotionEventHandler(string message);

    public class MotionSensor
    {
       
        public event MotionEventHandler OnMotionDetected;

        public void DetectMotion(bool isMotion)
        {
            if (isMotion)
            {
                // Правильный вызов события с проверкой на null
                OnMotionDetected?.Invoke("Обнаружено движение в коридоре");
            }
        }
    }
}

