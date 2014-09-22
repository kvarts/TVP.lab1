namespace TVP.lab1.var5
{
	partial class Form1
	{
		/// <summary>
		/// Требуется переменная конструктора.
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
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.InputData = new System.Windows.Forms.TableLayoutPanel();
			this.A_priority = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.A_twork = new System.Windows.Forms.TextBox();
			this.B_priority = new System.Windows.Forms.TextBox();
			this.B_twork = new System.Windows.Forms.TextBox();
			this.B_start = new System.Windows.Forms.TextBox();
			this.C_start = new System.Windows.Forms.TextBox();
			this.A_start = new System.Windows.Forms.TextBox();
			this.C_twork = new System.Windows.Forms.TextBox();
			this.C_priority = new System.Windows.Forms.TextBox();
			this.D_priority = new System.Windows.Forms.TextBox();
			this.D_twork = new System.Windows.Forms.TextBox();
			this.D_start = new System.Windows.Forms.TextBox();
			this.E_start = new System.Windows.Forms.TextBox();
			this.E_twork = new System.Windows.Forms.TextBox();
			this.E_priority = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.FCFS = new System.Windows.Forms.Button();
			this.RoundRobin = new System.Windows.Forms.Button();
			this.ShortestJobFirst = new System.Windows.Forms.Button();
			this.PriorityPlaninig = new System.Windows.Forms.Button();
			this.ShortestRemainingTime = new System.Windows.Forms.Button();
			this.HRRN = new System.Windows.Forms.Button();
			this.debug = new System.Windows.Forms.Label();
			this.Diagramm = new System.Windows.Forms.PictureBox();
			this.InputData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Diagramm)).BeginInit();
			this.SuspendLayout();
			// 
			// InputData
			// 
			this.InputData.ColumnCount = 6;
			this.InputData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.InputData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.InputData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.InputData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.InputData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.InputData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
			this.InputData.Controls.Add(this.A_priority, 1, 3);
			this.InputData.Controls.Add(this.label6, 0, 1);
			this.InputData.Controls.Add(this.label7, 0, 2);
			this.InputData.Controls.Add(this.label8, 0, 3);
			this.InputData.Controls.Add(this.A_twork, 1, 2);
			this.InputData.Controls.Add(this.B_priority, 2, 3);
			this.InputData.Controls.Add(this.B_twork, 2, 2);
			this.InputData.Controls.Add(this.B_start, 2, 1);
			this.InputData.Controls.Add(this.C_start, 3, 1);
			this.InputData.Controls.Add(this.A_start, 1, 1);
			this.InputData.Controls.Add(this.C_twork, 3, 2);
			this.InputData.Controls.Add(this.C_priority, 3, 3);
			this.InputData.Controls.Add(this.D_priority, 4, 3);
			this.InputData.Controls.Add(this.D_twork, 4, 2);
			this.InputData.Controls.Add(this.D_start, 4, 1);
			this.InputData.Controls.Add(this.E_start, 5, 1);
			this.InputData.Controls.Add(this.E_twork, 5, 2);
			this.InputData.Controls.Add(this.E_priority, 5, 3);
			this.InputData.Controls.Add(this.label5, 1, 0);
			this.InputData.Controls.Add(this.label1, 2, 0);
			this.InputData.Controls.Add(this.label2, 3, 0);
			this.InputData.Controls.Add(this.label3, 4, 0);
			this.InputData.Controls.Add(this.label4, 5, 0);
			this.InputData.Location = new System.Drawing.Point(13, 13);
			this.InputData.Name = "InputData";
			this.InputData.RowCount = 4;
			this.InputData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.InputData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.InputData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.InputData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.InputData.Size = new System.Drawing.Size(652, 121);
			this.InputData.TabIndex = 0;
			// 
			// A_priority
			// 
			this.A_priority.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.A_priority.Location = new System.Drawing.Point(150, 90);
			this.A_priority.Margin = new System.Windows.Forms.Padding(0);
			this.A_priority.Name = "A_priority";
			this.A_priority.Size = new System.Drawing.Size(100, 29);
			this.A_priority.TabIndex = 10;
			this.A_priority.Text = "1";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(3, 30);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(144, 30);
			this.label6.TabIndex = 1;
			this.label6.Text = "Время запуска";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(3, 60);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(144, 30);
			this.label7.TabIndex = 1;
			this.label7.Text = "Время обслуживания";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(3, 90);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(144, 31);
			this.label8.TabIndex = 1;
			this.label8.Text = "Приоритет";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// A_twork
			// 
			this.A_twork.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.A_twork.Location = new System.Drawing.Point(150, 60);
			this.A_twork.Margin = new System.Windows.Forms.Padding(0);
			this.A_twork.Name = "A_twork";
			this.A_twork.Size = new System.Drawing.Size(100, 29);
			this.A_twork.TabIndex = 5;
			this.A_twork.Text = "4";
			// 
			// B_priority
			// 
			this.B_priority.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.B_priority.Location = new System.Drawing.Point(250, 90);
			this.B_priority.Margin = new System.Windows.Forms.Padding(0);
			this.B_priority.Name = "B_priority";
			this.B_priority.Size = new System.Drawing.Size(100, 29);
			this.B_priority.TabIndex = 11;
			this.B_priority.Text = "2";
			// 
			// B_twork
			// 
			this.B_twork.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.B_twork.Location = new System.Drawing.Point(250, 60);
			this.B_twork.Margin = new System.Windows.Forms.Padding(0);
			this.B_twork.Name = "B_twork";
			this.B_twork.Size = new System.Drawing.Size(100, 29);
			this.B_twork.TabIndex = 6;
			this.B_twork.Text = "6";
			// 
			// B_start
			// 
			this.B_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.B_start.Location = new System.Drawing.Point(250, 30);
			this.B_start.Margin = new System.Windows.Forms.Padding(0);
			this.B_start.Name = "B_start";
			this.B_start.Size = new System.Drawing.Size(100, 29);
			this.B_start.TabIndex = 1;
			this.B_start.Text = "2";
			// 
			// C_start
			// 
			this.C_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.C_start.Location = new System.Drawing.Point(350, 30);
			this.C_start.Margin = new System.Windows.Forms.Padding(0);
			this.C_start.Name = "C_start";
			this.C_start.Size = new System.Drawing.Size(100, 29);
			this.C_start.TabIndex = 2;
			this.C_start.Text = "5";
			// 
			// A_start
			// 
			this.A_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.A_start.Location = new System.Drawing.Point(150, 30);
			this.A_start.Margin = new System.Windows.Forms.Padding(0);
			this.A_start.Name = "A_start";
			this.A_start.Size = new System.Drawing.Size(100, 29);
			this.A_start.TabIndex = 0;
			this.A_start.Text = "0";
			// 
			// C_twork
			// 
			this.C_twork.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.C_twork.Location = new System.Drawing.Point(350, 60);
			this.C_twork.Margin = new System.Windows.Forms.Padding(0);
			this.C_twork.Name = "C_twork";
			this.C_twork.Size = new System.Drawing.Size(100, 29);
			this.C_twork.TabIndex = 7;
			this.C_twork.Text = "3";
			// 
			// C_priority
			// 
			this.C_priority.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.C_priority.Location = new System.Drawing.Point(350, 90);
			this.C_priority.Margin = new System.Windows.Forms.Padding(0);
			this.C_priority.Name = "C_priority";
			this.C_priority.Size = new System.Drawing.Size(100, 29);
			this.C_priority.TabIndex = 12;
			this.C_priority.Text = "3";
			// 
			// D_priority
			// 
			this.D_priority.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.D_priority.Location = new System.Drawing.Point(450, 90);
			this.D_priority.Margin = new System.Windows.Forms.Padding(0);
			this.D_priority.Name = "D_priority";
			this.D_priority.Size = new System.Drawing.Size(100, 29);
			this.D_priority.TabIndex = 13;
			this.D_priority.Text = "4";
			// 
			// D_twork
			// 
			this.D_twork.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.D_twork.Location = new System.Drawing.Point(450, 60);
			this.D_twork.Margin = new System.Windows.Forms.Padding(0);
			this.D_twork.Name = "D_twork";
			this.D_twork.Size = new System.Drawing.Size(100, 29);
			this.D_twork.TabIndex = 8;
			this.D_twork.Text = "1";
			// 
			// D_start
			// 
			this.D_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.D_start.Location = new System.Drawing.Point(450, 30);
			this.D_start.Margin = new System.Windows.Forms.Padding(0);
			this.D_start.Name = "D_start";
			this.D_start.Size = new System.Drawing.Size(100, 29);
			this.D_start.TabIndex = 3;
			this.D_start.Text = "8";
			// 
			// E_start
			// 
			this.E_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.E_start.Location = new System.Drawing.Point(550, 30);
			this.E_start.Margin = new System.Windows.Forms.Padding(0);
			this.E_start.Name = "E_start";
			this.E_start.Size = new System.Drawing.Size(100, 29);
			this.E_start.TabIndex = 4;
			this.E_start.Text = "10";
			// 
			// E_twork
			// 
			this.E_twork.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.E_twork.Location = new System.Drawing.Point(550, 60);
			this.E_twork.Margin = new System.Windows.Forms.Padding(0);
			this.E_twork.Name = "E_twork";
			this.E_twork.Size = new System.Drawing.Size(100, 29);
			this.E_twork.TabIndex = 9;
			this.E_twork.Text = "5";
			// 
			// E_priority
			// 
			this.E_priority.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.E_priority.Location = new System.Drawing.Point(550, 90);
			this.E_priority.Margin = new System.Windows.Forms.Padding(0);
			this.E_priority.Name = "E_priority";
			this.E_priority.Size = new System.Drawing.Size(100, 29);
			this.E_priority.TabIndex = 14;
			this.E_priority.Text = "5";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(153, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 30);
			this.label5.TabIndex = 1;
			this.label5.Text = "A";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(253, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 30);
			this.label1.TabIndex = 1;
			this.label1.Text = "B";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(353, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 30);
			this.label2.TabIndex = 1;
			this.label2.Text = "C";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(453, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 30);
			this.label3.TabIndex = 1;
			this.label3.Text = "D";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(553, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 30);
			this.label4.TabIndex = 1;
			this.label4.Text = "E";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FCFS
			// 
			this.FCFS.Location = new System.Drawing.Point(13, 167);
			this.FCFS.Name = "FCFS";
			this.FCFS.Size = new System.Drawing.Size(141, 36);
			this.FCFS.TabIndex = 1;
			this.FCFS.Text = "FCFS";
			this.FCFS.UseVisualStyleBackColor = true;
			this.FCFS.Click += new System.EventHandler(this.FCFS_Click);
			// 
			// RoundRobin
			// 
			this.RoundRobin.Location = new System.Drawing.Point(13, 209);
			this.RoundRobin.Name = "RoundRobin";
			this.RoundRobin.Size = new System.Drawing.Size(141, 36);
			this.RoundRobin.TabIndex = 1;
			this.RoundRobin.Text = "Round Robin";
			this.RoundRobin.UseVisualStyleBackColor = true;
			// 
			// ShortestJobFirst
			// 
			this.ShortestJobFirst.Location = new System.Drawing.Point(160, 167);
			this.ShortestJobFirst.Name = "ShortestJobFirst";
			this.ShortestJobFirst.Size = new System.Drawing.Size(141, 36);
			this.ShortestJobFirst.TabIndex = 1;
			this.ShortestJobFirst.Text = "Shortest Job First";
			this.ShortestJobFirst.UseVisualStyleBackColor = true;
			// 
			// PriorityPlaninig
			// 
			this.PriorityPlaninig.Location = new System.Drawing.Point(307, 167);
			this.PriorityPlaninig.Name = "PriorityPlaninig";
			this.PriorityPlaninig.Size = new System.Drawing.Size(141, 36);
			this.PriorityPlaninig.TabIndex = 1;
			this.PriorityPlaninig.Text = "Приоритетное планирование";
			this.PriorityPlaninig.UseVisualStyleBackColor = true;
			this.PriorityPlaninig.Click += new System.EventHandler(this.PriorityPlaninig_Click);
			// 
			// ShortestRemainingTime
			// 
			this.ShortestRemainingTime.Location = new System.Drawing.Point(160, 209);
			this.ShortestRemainingTime.Name = "ShortestRemainingTime";
			this.ShortestRemainingTime.Size = new System.Drawing.Size(141, 36);
			this.ShortestRemainingTime.TabIndex = 1;
			this.ShortestRemainingTime.Text = "Shortest remaining time";
			this.ShortestRemainingTime.UseVisualStyleBackColor = true;
			// 
			// HRRN
			// 
			this.HRRN.Location = new System.Drawing.Point(307, 209);
			this.HRRN.Name = "HRRN";
			this.HRRN.Size = new System.Drawing.Size(141, 36);
			this.HRRN.TabIndex = 1;
			this.HRRN.Text = "HRRN";
			this.HRRN.UseVisualStyleBackColor = true;
			this.HRRN.Click += new System.EventHandler(this.HRRN_Click);
			// 
			// debug
			// 
			this.debug.BackColor = System.Drawing.SystemColors.Highlight;
			this.debug.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.debug.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.debug.Location = new System.Drawing.Point(16, 523);
			this.debug.Name = "debug";
			this.debug.Size = new System.Drawing.Size(658, 132);
			this.debug.TabIndex = 2;
			// 
			// Diagramm
			// 
			this.Diagramm.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Diagramm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Diagramm.Location = new System.Drawing.Point(13, 252);
			this.Diagramm.Name = "Diagramm";
			this.Diagramm.Size = new System.Drawing.Size(435, 33);
			this.Diagramm.TabIndex = 3;
			this.Diagramm.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(683, 664);
			this.Controls.Add(this.Diagramm);
			this.Controls.Add(this.debug);
			this.Controls.Add(this.HRRN);
			this.Controls.Add(this.ShortestRemainingTime);
			this.Controls.Add(this.PriorityPlaninig);
			this.Controls.Add(this.ShortestJobFirst);
			this.Controls.Add(this.RoundRobin);
			this.Controls.Add(this.FCFS);
			this.Controls.Add(this.InputData);
			this.Name = "Form1";
			this.Text = "Form1";
			this.InputData.ResumeLayout(false);
			this.InputData.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Diagramm)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel InputData;
		private System.Windows.Forms.TextBox A_priority;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox A_twork;
		private System.Windows.Forms.TextBox B_priority;
		private System.Windows.Forms.TextBox B_twork;
		private System.Windows.Forms.TextBox A_start;
		private System.Windows.Forms.TextBox B_start;
		private System.Windows.Forms.TextBox C_start;
		private System.Windows.Forms.TextBox C_twork;
		private System.Windows.Forms.TextBox C_priority;
		private System.Windows.Forms.TextBox D_priority;
		private System.Windows.Forms.TextBox D_twork;
		private System.Windows.Forms.TextBox D_start;
		private System.Windows.Forms.TextBox E_start;
		private System.Windows.Forms.TextBox E_twork;
		private System.Windows.Forms.TextBox E_priority;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button FCFS;
		private System.Windows.Forms.Button RoundRobin;
		private System.Windows.Forms.Button ShortestJobFirst;
		private System.Windows.Forms.Button PriorityPlaninig;
		private System.Windows.Forms.Button ShortestRemainingTime;
		private System.Windows.Forms.Button HRRN;
		private System.Windows.Forms.Label debug;
		private System.Windows.Forms.PictureBox Diagramm;
	}
}

