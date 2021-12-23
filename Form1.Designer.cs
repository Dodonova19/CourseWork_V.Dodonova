
namespace CourseWork_V.Dodonova
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblSpeed = new System.Windows.Forms.Label();
            this.tbSpreading = new System.Windows.Forms.TrackBar();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.lblSpreading = new System.Windows.Forms.Label();
            this.lblCountOfParticlesPerTick = new System.Windows.Forms.Label();
            this.tbCountOfPariclesPerTick = new System.Windows.Forms.TrackBar();
            this.lblDirection = new System.Windows.Forms.Label();
            this.tbDirection = new System.Windows.Forms.TrackBar();
            this.lblCountOfActiveParticles = new System.Windows.Forms.Label();
            this.lblLifeOfParticle = new System.Windows.Forms.Label();
            this.tbLifeOfParticle = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCountOfPariclesPerTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLifeOfParticle)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(0, 0);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(725, 637);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 40;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSpeed.Location = new System.Drawing.Point(740, 104);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(88, 18);
            this.lblSpeed.TabIndex = 5;
            this.lblSpeed.Text = "Скорость";
            // 
            // tbSpreading
            // 
            this.tbSpreading.Location = new System.Drawing.Point(743, 56);
            this.tbSpreading.Maximum = 300;
            this.tbSpreading.Minimum = 10;
            this.tbSpreading.Name = "tbSpreading";
            this.tbSpreading.Size = new System.Drawing.Size(213, 45);
            this.tbSpreading.TabIndex = 6;
            this.tbSpreading.Value = 10;
            this.tbSpreading.Scroll += new System.EventHandler(this.tbSpreading_Scroll);
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(743, 136);
            this.tbSpeed.Maximum = 25;
            this.tbSpeed.Minimum = 5;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(210, 45);
            this.tbSpeed.TabIndex = 7;
            this.tbSpeed.Value = 5;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            // 
            // lblSpreading
            // 
            this.lblSpreading.AutoSize = true;
            this.lblSpreading.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSpreading.Location = new System.Drawing.Point(740, 25);
            this.lblSpreading.Name = "lblSpreading";
            this.lblSpreading.Size = new System.Drawing.Size(78, 18);
            this.lblSpreading.TabIndex = 8;
            this.lblSpreading.Text = "Разброс";
            // 
            // lblCountOfParticlesPerTick
            // 
            this.lblCountOfParticlesPerTick.AutoSize = true;
            this.lblCountOfParticlesPerTick.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountOfParticlesPerTick.Location = new System.Drawing.Point(740, 184);
            this.lblCountOfParticlesPerTick.Name = "lblCountOfParticlesPerTick";
            this.lblCountOfParticlesPerTick.Size = new System.Drawing.Size(208, 18);
            this.lblCountOfParticlesPerTick.TabIndex = 9;
            this.lblCountOfParticlesPerTick.Text = "Кол-во частиц за тик";
            // 
            // tbCountOfPariclesPerTick
            // 
            this.tbCountOfPariclesPerTick.Location = new System.Drawing.Point(743, 215);
            this.tbCountOfPariclesPerTick.Maximum = 50;
            this.tbCountOfPariclesPerTick.Minimum = 1;
            this.tbCountOfPariclesPerTick.Name = "tbCountOfPariclesPerTick";
            this.tbCountOfPariclesPerTick.Size = new System.Drawing.Size(210, 45);
            this.tbCountOfPariclesPerTick.TabIndex = 10;
            this.tbCountOfPariclesPerTick.Value = 1;
            this.tbCountOfPariclesPerTick.Scroll += new System.EventHandler(this.tbCountOfPariclesPerTick_Scroll);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDirection.Location = new System.Drawing.Point(740, 263);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(118, 18);
            this.lblDirection.TabIndex = 11;
            this.lblDirection.Text = "Направление";
            // 
            // tbDirection
            // 
            this.tbDirection.Location = new System.Drawing.Point(743, 295);
            this.tbDirection.Maximum = 359;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(210, 45);
            this.tbDirection.TabIndex = 12;
            this.tbDirection.Value = 90;
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll);
            // 
            // lblCountOfActiveParticles
            // 
            this.lblCountOfActiveParticles.AutoSize = true;
            this.lblCountOfActiveParticles.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountOfActiveParticles.Location = new System.Drawing.Point(740, 434);
            this.lblCountOfActiveParticles.Name = "lblCountOfActiveParticles";
            this.lblCountOfActiveParticles.Size = new System.Drawing.Size(228, 18);
            this.lblCountOfActiveParticles.TabIndex = 13;
            this.lblCountOfActiveParticles.Text = "Кол-во активных частиц";
            // 
            // lblLifeOfParticle
            // 
            this.lblLifeOfParticle.AutoSize = true;
            this.lblLifeOfParticle.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLifeOfParticle.Location = new System.Drawing.Point(740, 343);
            this.lblLifeOfParticle.Name = "lblLifeOfParticle";
            this.lblLifeOfParticle.Size = new System.Drawing.Size(238, 18);
            this.lblLifeOfParticle.TabIndex = 14;
            this.lblLifeOfParticle.Text = "Продолжительность жизни";
            // 
            // tbLifeOfParticle
            // 
            this.tbLifeOfParticle.Location = new System.Drawing.Point(743, 376);
            this.tbLifeOfParticle.Maximum = 100;
            this.tbLifeOfParticle.Minimum = 10;
            this.tbLifeOfParticle.Name = "tbLifeOfParticle";
            this.tbLifeOfParticle.Size = new System.Drawing.Size(210, 45);
            this.tbLifeOfParticle.TabIndex = 15;
            this.tbLifeOfParticle.Value = 90;
            this.tbLifeOfParticle.Scroll += new System.EventHandler(this.tbLifeOfParticle_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 636);
            this.Controls.Add(this.tbLifeOfParticle);
            this.Controls.Add(this.lblLifeOfParticle);
            this.Controls.Add(this.lblCountOfActiveParticles);
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.tbCountOfPariclesPerTick);
            this.Controls.Add(this.lblCountOfParticlesPerTick);
            this.Controls.Add(this.lblSpreading);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.tbSpreading);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCountOfPariclesPerTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLifeOfParticle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TrackBar tbSpreading;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.Label lblSpreading;
        private System.Windows.Forms.Label lblCountOfParticlesPerTick;
        private System.Windows.Forms.TrackBar tbCountOfPariclesPerTick;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.TrackBar tbDirection;
        private System.Windows.Forms.Label lblCountOfActiveParticles;
        private System.Windows.Forms.Label lblLifeOfParticle;
        private System.Windows.Forms.TrackBar tbLifeOfParticle;
    }
}

