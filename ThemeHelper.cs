using System;
using System.Drawing;
using System.Windows.Forms;

namespace patch_seb_lucas
{
	internal static class ThemeHelper
	{
		private static readonly Color Background = Color.Black;
		private static readonly Color Foreground = Color.Lime;
		private static readonly Font DefaultFont = new Font("Consolas", 9.0f, FontStyle.Regular, GraphicsUnit.Point);

		public static void ApplyHackerTheme(Form form)
		{
			if (form == null)
			{
				return;
			}

			form.BackColor = Background;
			form.ForeColor = Foreground;
			form.Font = new Font(DefaultFont, FontStyle.Regular);

			// Draw a subtle neon border around the form
			form.Paint -= OnFormPaint; // avoid multiple attachments
			form.Paint += OnFormPaint;

			ApplyToChildren(form);
		}

		private static void OnFormPaint(object sender, PaintEventArgs e)
		{
			ControlPaint.DrawBorder(e.Graphics, ((Form)sender).ClientRectangle, Foreground, ButtonBorderStyle.Solid);
		}

		private static void ApplyToChildren(Control parent)
		{
			foreach (Control child in parent.Controls)
			{
				ApplyToControl(child);
				if (child.HasChildren)
				{
					ApplyToChildren(child);
				}
			}
		}

		private static void ApplyToControl(Control control)
		{
			control.BackColor = Background;
			control.ForeColor = Foreground;
			control.Font = control.Font.Name == DefaultFont.Name ? control.Font : new Font(DefaultFont, control.Font.Style);

			switch (control)
			{
				case Button btn:
					StyleButton(btn);
					break;
				case TextBox tb:
					StyleTextBox(tb);
					break;
				case GroupBox gb:
					gb.ForeColor = Foreground;
					gb.BackColor = Background;
					break;
				case CheckBox cb:
					cb.BackColor = Background;
					cb.ForeColor = Foreground;
					break;
				case RadioButton rb:
					rb.BackColor = Background;
					rb.ForeColor = Foreground;
					break;
				case ComboBox combo:
					combo.BackColor = Background;
					combo.ForeColor = Foreground;
					break;
				case Label lbl:
					lbl.ForeColor = Foreground;
					break;
			}
		}

		private static void StyleButton(Button button)
		{
			button.FlatStyle = FlatStyle.Flat;
			button.FlatAppearance.BorderSize = 1;
			button.FlatAppearance.BorderColor = Foreground;
			button.BackColor = Background;
			button.ForeColor = Foreground;

			// Simple hover effect
			button.MouseEnter -= OnButtonMouseEnter;
			button.MouseLeave -= OnButtonMouseLeave;
			button.MouseEnter += OnButtonMouseEnter;
			button.MouseLeave += OnButtonMouseLeave;
		}

		private static void OnButtonMouseEnter(object sender, EventArgs e)
		{
			var btn = (Button)sender;
			btn.BackColor = Color.FromArgb(16, 32, 16);
		}

		private static void OnButtonMouseLeave(object sender, EventArgs e)
		{
			var btn = (Button)sender;
			btn.BackColor = Background;
		}

		private static void StyleTextBox(TextBox textBox)
		{
			textBox.BackColor = Background;
			textBox.ForeColor = Foreground;
			textBox.BorderStyle = BorderStyle.FixedSingle;
		}
	}
}


