using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CourseWork_V.Dodonova
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>(); // Список эмиттеров
        Emitter emitter; // Сам эмиттер

        float x, y, x1, y1;

        public Form1()
        {
            InitializeComponent();

            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height); // Привязка изображения
           
            this.emitter = new Emitter // создаю эмиттер и привязываю его к полю emitter
            {
                RadiusMin = 1, // Задаю минимальный радиус
                RadiusMax = 5, // Задаю максимальный радиус
                Direction = 90, // Направление движения
                Spreading = 10, // Разброс частицы
                SpeedMin = 10, // Минимальная скорость частицы
                SpeedMax = 25, // Максимальная скорость частицы
                ColorFrom = Color.Gold, // Начальный цвет частицы
                ColorTo = Color.FromArgb(0, Color.Red), // Градация цвета частицы от золотого к красному
                ParticlesPerTick = 10, // Начальное кол-во частиц за тик
                X = picDisplay.Width / 2, // X координата частицы в пространстве (по центру picDisplay.X)
                Y = picDisplay.Height / 2, // Y координата частицы в пространстве (по центру picDisplay.Y)
            }; 
            emitters.Add(this.emitter); // Добавляю эмиттер в список 
        }

        private void timer_Tick(object sender, EventArgs e) // Событие для таймера
        {
            emitter.UpdateState(); // Каждый тик обновляем систему
            // Вывод кол-ва активных частиц 
            lblCountOfActiveParticles.Text = "Кол-во активных частиц: \n" + emitter.ParticlesCount.ToString();
            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black); // Очистка и присвоение picDisplay черного цвета
                emitter.Render(g); // Рендер системы
            }
            picDisplay.Invalidate(); // Обновление picDisplay
        }
        private void tbCountOfPariclesPerTick_Scroll(object sender, EventArgs e) // Кол-во частиц в такт или тик
        {
            emitter.ParticlesPerTick = tbCountOfPariclesPerTick.Value;
        }
        private void tbDirection_Scroll(object sender, EventArgs e) // Направление движения частиц
        {
            emitter.Direction = tbDirection.Value;
        }
        private void tbLifeOfParticle_Scroll(object sender, EventArgs e) // Продолжительность жизни частиц
        {
            emitter.LifeMax = tbLifeOfParticle.Value;
        }
        private void tbSpreading_Scroll(object sender, EventArgs e) // Разброс частиц
        {
           emitter.Spreading = tbSpreading.Value;
        }
        private void tbSpeed_Scroll(object sender, EventArgs e) // Скорость движения частиц
        {
            emitter.SpeedMin = tbSpeed.Value;
        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e) // Дижение эмиттера по нажатию левой кнопки мыши
        {
            if (e.Button == MouseButtons.Left)
            {
                emitter.X = e.X;
                emitter.Y = e.Y;
            }
        }
    }
}
