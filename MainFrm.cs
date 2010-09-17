using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace TrafficSim {
	public partial class MainFrm : Form {

		private Thread RendererThread;

		public MainFrm() {
			InitializeComponent();
		}

		private void MainFrm_Load(object sender, EventArgs e) {
			RendererThread = new Thread(new ThreadStart(Renderer.StartRenderer));
			RendererThread.Start();
			Renderer.SetParent(this);
			Thread.Sleep(100);
			this.Focus();
			this.Left = Renderer.ScreenPosition.Left + 512;
			this.Top = Renderer.ScreenPosition.Top - 5;
		}

		private void MainFrm_FormClosing(object sender, FormClosingEventArgs e) {
			Renderer.StopRenderer();
		}

		private void FPSTrack_Scroll(object sender, EventArgs e) {
			Renderer.MaxFPS = FPSTrack.Value;
		}

	}
}
