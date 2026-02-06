using System;
using System.Drawing;
using System.Windows.Forms;

namespace TS4SimRipper
{
    /// <summary>
    /// Helper class to apply dark mode theme to Windows Forms controls
    /// </summary>
    public static class DarkModeHelper
    {
        // Dark mode colors
        private static readonly Color DarkBackground = Color.FromArgb(30, 30, 30);
        private static readonly Color DarkControl = Color.FromArgb(45, 45, 45);
        private static readonly Color DarkBorder = Color.FromArgb(60, 60, 60);
        private static readonly Color DarkText = Color.FromArgb(220, 220, 220);
        private static readonly Color DarkAccent = Color.FromArgb(0, 120, 215);
        
        // Light mode colors (default Windows)
        private static readonly Color LightBackground = SystemColors.Control;
        private static readonly Color LightControl = SystemColors.Window;
        private static readonly Color LightText = SystemColors.ControlText;

        /// <summary>
        /// Apply theme to a form and all its child controls
        /// </summary>
        public static void ApplyTheme(Form form, bool darkMode)
        {
            if (darkMode)
            {
                form.BackColor = DarkBackground;
                form.ForeColor = DarkText;
            }
            else
            {
                form.BackColor = LightBackground;
                form.ForeColor = LightText;
            }
            
            ApplyThemeToControls(form.Controls, darkMode);
        }

        private static void ApplyThemeToControls(Control.ControlCollection controls, bool darkMode)
        {
            foreach (Control control in controls)
            {
                ApplyThemeToControl(control, darkMode);
                
                // Recursively apply to child controls
                if (control.HasChildren)
                {
                    ApplyThemeToControls(control.Controls, darkMode);
                }
            }
        }

        private static void ApplyThemeToControl(Control control, bool darkMode)
        {
            if (darkMode)
            {
                control.ForeColor = DarkText;
                
                if (control is Button btn)
                {
                    btn.BackColor = DarkControl;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = DarkBorder;
                }
                else if (control is TextBox txt)
                {
                    txt.BackColor = DarkControl;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (control is ComboBox cmb)
                {
                    cmb.BackColor = DarkControl;
                    cmb.FlatStyle = FlatStyle.Flat;
                }
                else if (control is ListBox lst)
                {
                    lst.BackColor = DarkControl;
                }
                else if (control is CheckBox chk)
                {
                    chk.BackColor = Color.Transparent;
                }
                else if (control is RadioButton rad)
                {
                    rad.BackColor = Color.Transparent;
                }
                else if (control is Panel pnl)
                {
                    pnl.BackColor = DarkBackground;
                }
                else if (control is Label lbl)
                {
                    lbl.BackColor = Color.Transparent;
                }
                else if (control is MenuStrip menu)
                {
                    menu.BackColor = DarkControl;
                    menu.ForeColor = DarkText;
                    foreach (ToolStripItem item in menu.Items)
                    {
                        if (item is ToolStripMenuItem menuItem)
                        {
                            menuItem.BackColor = DarkControl;
                            menuItem.ForeColor = DarkText;
                        }
                    }
                }
                else if (control is NumericUpDown num)
                {
                    num.BackColor = DarkControl;
                }
                else if (control is TrackBar)
                {
                    control.BackColor = DarkBackground;
                }
                else if (control is CheckedListBox clb)
                {
                    clb.BackColor = DarkControl;
                }
                else
                {
                    // Default for other controls
                    control.BackColor = DarkBackground;
                }
            }
            else
            {
                // Reset to light mode defaults
                if (control is Button btn)
                {
                    btn.BackColor = SystemColors.Control;
                    btn.FlatStyle = FlatStyle.Standard;
                    btn.UseVisualStyleBackColor = true;
                }
                else if (control is TextBox txt)
                {
                    txt.BackColor = LightControl;
                    txt.BorderStyle = BorderStyle.Fixed3D;
                }
                else if (control is ComboBox cmb)
                {
                    cmb.BackColor = LightControl;
                    cmb.FlatStyle = FlatStyle.Standard;
                }
                else if (control is ListBox lst)
                {
                    lst.BackColor = LightControl;
                }
                else if (control is Panel pnl)
                {
                    pnl.BackColor = LightBackground;
                }
                else if (control is MenuStrip menu)
                {
                    menu.BackColor = SystemColors.MenuBar;
                    menu.ForeColor = LightText;
                    foreach (ToolStripItem item in menu.Items)
                    {
                        if (item is ToolStripMenuItem menuItem)
                        {
                            menuItem.BackColor = SystemColors.MenuBar;
                            menuItem.ForeColor = LightText;
                        }
                    }
                }
                else
                {
                    control.BackColor = LightBackground;
                }
                
                control.ForeColor = LightText;
            }
        }
    }
}
