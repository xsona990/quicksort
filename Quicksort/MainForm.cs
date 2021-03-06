﻿using Quicksort.tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quicksort
{
    public partial class MainForm : Form
    {
        int[] result;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }


        private void generateBtn_Click(object sender, EventArgs e)
        {
            progress.Value = 0;
            generatedArrayBox.Clear();
            int elCount, max, min;
            elCount = parse(elCountBox.Text, elCountBox.Name);
            max = parse(maxValueBox.Text, maxValueBox.Name);
            min = parse(minValueBox.Text, minValueBox.Name);
            if (elCount > 0)
                if (max > min)
                {
                    result = randomArrayGeneration.generateArray(elCount, min, max);
                    if (result != null)
                    {
                        progress.Maximum = elCount;
                        foreach (int value in result)
                        {
                            progress.Value++;
                            generatedArrayBox.Text += value.ToString() + " ";
                        }
                    }
                    progress.Value = 0;
                    status.Text = "Ready!";
                }
                else
                {
                    MessageBox.Show("Wrong border values!");
                    elCountBox.Clear();
                    maxValueBox.Clear();
                    minValueBox.Clear();
                }
            else
            {
                MessageBox.Show("Elements count can`t be less than zero!");
            }
        }

        private int parse(string value, string name)
        {   int number;
            bool result = Int32.TryParse(value, out number);
            if (!result)
            {
                MessageBox.Show("Conversion failed, check inputed values");
               
                return -1;
            }
           
            return number;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            progress.Value = 0;
            sortedArrayBox.Clear();
            Quicksort qs = new Quicksort();
            result= qs.sorting(result, 0, result.Length - 1);
            if (result != null)
            {
                progress.Maximum = result.Length;
                 foreach (int value in result)
                 {
                     progress.Value++;
                     sortedArrayBox.Text += value.ToString() + " ";
                  }
               
            }
            progress.Value = 0;
            status.Text = "Ready!";
        }
    }
}
