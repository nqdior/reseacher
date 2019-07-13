﻿using Reseacher.Core;
using Reseacher.Properties;
using System;
using System.Windows;

namespace Reseacher
{
    public partial class MainWindow : MetroRadiance.UI.Controls.MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// メニューアイテムの挙動どこかにまとめたい
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            dragblzControl.AddServerAddPage();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (dragblzControl.Hacky == false)
            {
                aaaaa.Height = new GridLength(0);
                bbbbb.Height = new GridLength(0);
                stripArea.MinWidth = 0;
                stripArea.Width = new GridLength(0);
                ccccccccc.Width = new GridLength(0);
                dddddd.Visibility = Visibility.Hidden;
            }
            dragblzControl.FormLoadEnded();
        }

        private void GridSplitter_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Settings.Default.StripWidth = stripArea.Width.Value;
            Settings.Default.Save();
        }

        /// <summary> 最大化時にステータスバーが隠れないようにする対応。対応策模索中。 </summary>
        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double PSH = SystemParameters.PrimaryScreenHeight;
            int PSBH = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            double ratio = PSH / PSBH;
            int TaskBarHeight = PSBH - System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;
            TaskBarHeight *= (int)ratio;

            margin.Height = WindowState == WindowState.Maximized ? new GridLength(TaskBarHeight) : new GridLength(0);
        }
    }
}