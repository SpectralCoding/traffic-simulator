using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Threading;
using SdlDotNet.Graphics;
using SdlDotNet.Core;
using SdlDotNet.Input;

namespace TrafficSim {
	public static class Renderer {

		#region Members
		[DllImport("user32.dll")]
		private static extern int GetWindowRect(IntPtr hwnd, out Rectangle rect);
		private static Surface m_VideoScreen;
		private static Surface m_ViewSpace;
		private static Point m_ViewSpaceOffset = new Point(0, 0);
		private static Form m_ParentForm;
		private static Position m_WindowPosition = new Position();
		private static Size m_WindowSize = new Size(0, 0);
		private static SdlDotNet.Graphics.Font m_FpsFont;
		#endregion

		#region Properties
		public static Surface VideoScreen { get { return m_VideoScreen; } }
		public static Position ScreenPosition { get { return m_WindowPosition; } }
		public static Size ScreenSize { get { return m_WindowSize; } }
		public static int MaxFPS {
			get { return Events.TargetFps; }
			set { Events.TargetFps = value; }
		}
		#endregion

		public static void SetParent(Form iParentForm) { m_ParentForm = iParentForm; }

		/// <summary>
		/// Starts the SDL Renderer
		/// </summary>
		public static void StartRenderer() {
			m_VideoScreen = Video.SetVideoMode(500, 500, 32, true, false, false, true, true);
			m_FpsFont = new SdlDotNet.Graphics.Font(@"C:\Windows\Fonts\Arial.ttf", 14);
			#region Events Hooks
			Events.TargetFps = 2000;
			Events.Quit += new EventHandler<QuitEventArgs>(Renderer_Quit);
			Events.Tick += new EventHandler<TickEventArgs>(Renderer_Tick);
			Events.KeyboardDown += new EventHandler<KeyboardEventArgs>(Renderer_KeyDown);
			Keyboard.EnableKeyRepeat(0, 10);
			Keyboard.KeyRepeat = true;
			#endregion
			#region Size
			Rectangle tempRectangle;
			GetWindowRect(Video.WindowHandle, out tempRectangle);
			m_WindowPosition.Left = tempRectangle.Left; m_WindowPosition.Top = tempRectangle.Top;
			m_WindowSize = new Size(tempRectangle.Width, tempRectangle.Height);
			#endregion
			MapManager.BuildWorld();
			m_ViewSpace = MapManager.GetViewSpace(m_ViewSpaceOffset, m_VideoScreen.Size);
			Events.Run();
		}

		private static void Renderer_Quit(object sender, QuitEventArgs args) {
			Events.QuitApplication();
			Application.Exit();
		}

		private static void Renderer_Tick(object sender, TickEventArgs args) {
			m_VideoScreen.Fill(Color.Black);
			Surface fpsCounterSurface = m_FpsFont.Render(String.Format("FPS: {0}/{1}", Events.Fps, Events.TargetFps), Color.Yellow);
			m_VideoScreen.Blit(m_ViewSpace);
			m_VideoScreen.Blit(fpsCounterSurface, new Point(10, 10));


			m_VideoScreen.Update();

		}

		private static void Renderer_KeyDown(object sender, KeyboardEventArgs args) {
			switch (args.Key) {
				case Key.LeftArrow:
					if (m_ViewSpaceOffset.X >= 5) {
						m_ViewSpaceOffset.X -= 5;
					}
					break;
				case Key.RightArrow:
					if (m_ViewSpaceOffset.X + m_VideoScreen.Width - 5 <= MapManager.MapSizePixels.Width - 25) {
						m_ViewSpaceOffset.X += 5;
					}
					break;
				case Key.UpArrow:
					if (m_ViewSpaceOffset.Y >= 5) {
						m_ViewSpaceOffset.Y -= 5;
					}
					break;
				case Key.DownArrow:
					if (m_ViewSpaceOffset.Y + m_VideoScreen.Height - 5 <= MapManager.MapSizePixels.Height - 25) {
						m_ViewSpaceOffset.Y += 5;
					}
					break;
			}
			m_ViewSpace = MapManager.GetViewSpace(m_ViewSpaceOffset, m_ViewSpace.Size);
		}

		public static void StopRenderer() {
			Events.QuitApplication();
		}

	}

	#region Structs
	public struct Position {
		public int Top;
		public int Left;
	}
	#endregion
}
