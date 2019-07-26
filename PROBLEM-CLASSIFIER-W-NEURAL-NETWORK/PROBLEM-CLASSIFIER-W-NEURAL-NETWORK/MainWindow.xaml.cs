﻿using PROBLEM_CLASSIFIER_W_NEURAL_NETWORK.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PROBLEM_CLASSIFIER_W_NEURAL_NETWORK
{
    public partial class MainWindow : Window
    {
        CreateLearningLabelsControl cllc;

        public MainWindow()
        {
            InitializeComponent();


        }

        private void btn_learningLabels_Click(object sender, RoutedEventArgs e)
        {
            if (cllc == null) cllc = new CreateLearningLabelsControl();
            userControlHolder.Content = cllc;
        }
    }
}
