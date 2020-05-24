﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int curCount = 1, tabCount = 0;
        //int universal = 0;
        State[] states = new State[1];
        //string countrname, capital, continent, capitalEnter, continentEnter;

        private void enterBoxPopulation_Leave(object sender, EventArgs e)
        {
            if (long.Parse(enterBoxPopulation.Text) <= 0 || long.Parse(enterBoxPopulation.Text) > 10000000)
            {
                MessageBox.Show("Введите корректное значение");
                enterBoxPopulation.Focus();
            }
        }

        private void enterBoxArea_Leave(object sender, EventArgs e)
        {
            if (long.Parse(enterBoxArea.Text) <= 0 || long.Parse(enterBoxArea.Text) > 10000000)
            {
                MessageBox.Show("Введите корректное значение");
                enterBoxArea.Focus();
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save file";
            saveFileDialog1.Filter = "All files |*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                try
                {
                    BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate));
                    writer.Write(tabCount);
                    for (int i = 0; i < tabCount; i++)
                    {
                        writer.Write(states[i].Countrname);
                        writer.Write(states[i].Capital);
                        writer.Write(states[i].Continent);
                        writer.Write(states[i].Population);
                        writer.Write(states[i].Area);
                    }
                }
                catch (Exception s)
                {
                    MessageBox.Show(s.Message);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void appendBtn_Click(object sender, EventArgs e)
        {
            if (enterBoxName.Text != "" && enterBoxCapital.Text != "" && enterBoxContinent.Text != "" && enterBoxPopulation.Text != "" && enterBoxArea.Text != "")
            {
                enterChangeBox.Rows.Add();
                enterChangeBox.Rows[tabCount].Cells[0].Value = curCount;
                enterChangeBox.Rows[tabCount].Cells[1].Value = enterBoxName.Text;
                enterChangeBox.Rows[tabCount].Cells[2].Value = enterBoxCapital.Text;
                enterChangeBox.Rows[tabCount].Cells[3].Value = enterBoxContinent.Text;
                enterChangeBox.Rows[tabCount].Cells[4].Value = enterBoxPopulation.Text;
                enterChangeBox.Rows[tabCount].Cells[5].Value = enterBoxArea.Text;


                states[tabCount] = new State(enterBoxName.Text, enterBoxCapital.Text, enterBoxContinent.Text, int.Parse(enterBoxPopulation.Text), int.Parse(enterBoxArea.Text));
                states = addArr(states, curCount);
                curCount++;
                tabCount++;

                enterBoxName.Clear();
                enterBoxCapital.Clear();
                enterBoxContinent.SelectedIndex = -1;
                enterBoxPopulation.Clear();
                enterBoxArea.Clear();

            }
            else
            {
                MessageBox.Show("Не все поля заполнены!");
            }
        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Load file";
            openFileDialog1.Filter = "All files |*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                int counts = 0;
                try
                {
                    BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open));
                    counts = reader.ReadInt32();
                    for (int i = 0; i < counts; i++)
                    {
                        enterBoxName.Text = reader.ReadString();
                        enterBoxCapital.Text = reader.ReadString();
                        enterBoxContinent.Text = reader.ReadString();
                        enterBoxPopulation.Text = Convert.ToString(reader.ReadInt64());
                        enterBoxArea.Text = Convert.ToString(reader.ReadInt64());
                        appendBtn_Click(0, EventArgs.Empty);

                    }
                }
                catch (Exception s)
                {
                    MessageBox.Show(s.Message);
                }
            }
        }
        private void delBtn_Click(object sender, EventArgs e)
        {
            if(enterDelBox.Text == "" || Int32.Parse(enterDelBox.Text) <= 0 || Int32.Parse(enterDelBox.Text) > tabCount)
            {
                MessageBox.Show("Введено некоректное значение");
            }
            else
            {
                DelArr(states, curCount, Int32.Parse(enterDelBox.Text));
                curCount--;
                tabCount--;
                refreshFields(states, tabCount);
                enterDelBox.Clear();
            }

        }
        private void changeBtn_Click(object sender, EventArgs e)
        {
            if (changeBox.Text == "" || changeBox2.Text == "" || Int32.Parse(changeBox.Text) <= 0 || Int32.Parse(changeBox.Text) > tabCount)
            {
                MessageBox.Show("Введены некоректные значения!");
            }
            else
            {
                int num = Int32.Parse(changeBox.Text);
                string field = changeBox1.Text;
                string value = changeBox2.Text;
                states[num - 1].Change(field, value);
                refreshFields(states, tabCount);
            }
        }

        static State[] addArr(State[] arr, int count)
        {
            State[] statesTemp = new State[count + 1];
            for(int i = 0; i < count; i++)
            {
                statesTemp[i] = arr[i];
            }
            Array.Clear(arr, 0, count);
            return statesTemp;
        }


        static void DelArr(State[] arr, int count, int numEnter)
        {
            State[] statesTemp = new State[count-1];
            int c = 0;
            for (int i = 0; i < count; i++)
            {
                if(i == numEnter - 1)
                {
                    continue;
                }
                else
                {
                    statesTemp[c] = arr[i];
                    c++;
                }
            }
            Array.Clear(arr, 0, count);
            for(int i = 0; i < c; i++)
            {
                arr[i] = statesTemp[i];
            }
        }

        private void refreshFields(State[] arr, int count)
        {
            for (int i = 0; i < enterChangeBox.Rows.Count - 1; i++)
            {
                enterChangeBox.Rows.RemoveAt(i);
            }
            for (int i = 0; i < count; i++)
            {
                enterChangeBox.Rows.Add();
                enterChangeBox.Rows[i].Cells[0].Value = i + 1;
                enterChangeBox.Rows[i].Cells[1].Value = states[i].Countrname;
                enterChangeBox.Rows[i].Cells[2].Value = states[i].Capital;
                enterChangeBox.Rows[i].Cells[3].Value = states[i].Continent;
                enterChangeBox.Rows[i].Cells[4].Value = states[i].Population;
                enterChangeBox.Rows[i].Cells[5].Value = states[i].Area;
            }
        }

    }
}