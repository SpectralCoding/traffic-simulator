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
			((System.ComponentModel.ISupportInitialize)(this.FPSTrack)).BeginInit();
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
			// MainFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(515, 444);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.FPSTrack);
			this.Name = "MainFrm";
			this.Text = "TrafficSim Settings";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
			this.Load += new System.EventHandler(this.MainFrm_Load);
			((System.ComponentModel.ISupportInitialize)(this.FPSTrack)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TrackBar FPSTrack;
		private System.Windows.Forms.Label label1;
	}
}

