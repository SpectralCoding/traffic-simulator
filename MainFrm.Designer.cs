namespace TrafficSim {
	partial class MainFrm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.FPSTrack = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.CreateCityCmd = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.trackBar2 = new System.Windows.Forms.TrackBar();
			this.label4 = new System.Windows.Forms.Label();
			this.trackBar3 = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(this.FPSTrack)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
			this.SuspendLayout();
			// 
			// FPSTrack
			// 
			this.FPSTrack.AutoSize = false;
			this.FPSTrack.LargeChange = 100;
			this.FPSTrack.Location = new System.Drawing.Point(12, 25);
			this.FPSTrack.Maximum = 2000;
			this.FPSTrack.Minimum = 1;
			this.FPSTrack.Name = "FPSTrack";
			this.FPSTrack.Size = new System.Drawing.Size(200, 30);
			this.FPSTrack.SmallChange = 10;
			this.FPSTrack.TabIndex = 0;
			this.FPSTrack.TickFrequency = 100;
			this.FPSTrack.Value = 2000;
			this.FPSTrack.Scroll += new System.EventHandler(this.FPSTrack_Scroll);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Maximum FPS:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Road Density:";
			// 
			// trackBar1
			// 
			this.trackBar1.AutoSize = false;
			this.trackBar1.LargeChange = 100;
			this.trackBar1.Location = new System.Drawing.Point(12, 74);
			this.trackBar1.Maximum = 100;
			this.trackBar1.Minimum = 1;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(200, 30);
			this.trackBar1.SmallChange = 10;
			this.trackBar1.TabIndex = 2;
			this.trackBar1.TickFrequency = 10;
			this.trackBar1.Value = 50;
			// 
			// CreateCityCmd
			// 
			this.CreateCityCmd.Location = new System.Drawing.Point(12, 213);
			this.CreateCityCmd.Name = "CreateCityCmd";
			this.CreateCityCmd.Size = new System.Drawing.Size(75, 23);
			this.CreateCityCmd.TabIndex = 4;
			this.CreateCityCmd.Text = "Create City!";
			this.CreateCityCmd.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Suburbs:";
			// 
			// trackBar2
			// 
			this.trackBar2.AutoSize = false;
			this.trackBar2.LargeChange = 100;
			this.trackBar2.Location = new System.Drawing.Point(12, 123);
			this.trackBar2.Maximum = 5;
			this.trackBar2.Minimum = 1;
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Size = new System.Drawing.Size(200, 30);
			this.trackBar2.SmallChange = 10;
			this.trackBar2.TabIndex = 5;
			this.trackBar2.Value = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 156);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Commercial Districts:";
			// 
			// trackBar3
			// 
			this.trackBar3.AutoSize = false;
			this.trackBar3.LargeChange = 100;
			this.trackBar3.Location = new System.Drawing.Point(12, 172);
			this.trackBar3.Maximum = 5;
			this.trackBar3.Minimum = 1;
			this.trackBar3.Name = "trackBar3";
			this.trackBar3.Size = new System.Drawing.Size(200, 30);
			this.trackBar3.SmallChange = 10;
			this.trackBar3.TabIndex = 7;
			this.trackBar3.Value = 2;
			// 
			// MainFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 444);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.trackBar3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.trackBar2);
			this.Controls.Add(this.CreateCityCmd);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.FPSTrack);
			this.Name = "MainFrm";
			this.Text = "TrafficSim Settings";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
			this.Load += new System.EventHandler(this.MainFrm_Load);
			((System.ComponentModel.ISupportInitialize)(this.FPSTrack)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TrackBar FPSTrack;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Button CreateCityCmd;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TrackBar trackBar2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TrackBar trackBar3;
	}
}

