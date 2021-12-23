using System;
using System.Drawing;

namespace CourseWork_V.Dodonova
{
    public abstract class IImpactPoint // Этот класс не нужен, но пусть будет
    {
        public float X; // ну точка же, вот и две координаты
        public float Y;

        // абстрактный метод с помощью которого будем изменять состояние частиц
        // например притягивать или отталкивать
        public abstract void ImpactParticle(Particle particle);

        // базовый класс для отрисовки точечки
        public virtual void Render(Graphics g)
        {
            g.FillEllipse(
                    new SolidBrush(Color.Red),
                    X - 5,
                    Y - 5,
                    10,
                    10
                );
        }
    }

    public class Lines: IImpactPoint
    {
        int Power = 100;
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            float r2 = (float)Math.Max(100, gX * gX + gY * gY);

            particle.speedX += gX * Power / r2;
            particle.speedY += gY * Power / r2;
        }
    }
}
