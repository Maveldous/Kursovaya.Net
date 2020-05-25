using System;
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
        State[] states = new State[1];



        //Section1



        public Form1()
        {
            InitializeComponent();
        }

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
                refreshFields(enterChangeBox, states, tabCount);
                enterDelBox.Clear();
            }

        }
        private void changeBtn_Click(object sender, EventArgs e)
        {
            if (!passCheck() || changeBox.Text == "" || changeBox2.Text == "" || Int32.Parse(changeBox.Text) <= 0 || Int32.Parse(changeBox.Text) > tabCount)
            {
                MessageBox.Show("Введены некоректные значения!");
            }
            else
            {
                int num = Int32.Parse(changeBox.Text);
                string field = changeBox1.Text;
                string value = changeBox2.Text;
                states[num - 1].Change(field, value);
                refreshFields(enterChangeBox, states, tabCount);
            }
        }

        //Section2


        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            refreshFields(enterChangeBox1, states, tabCount);
        }

        private void massDelBtn_Click(object sender, EventArgs e)
        {
            long num = Int64.Parse(populDelBox.Text);
            massDelArr(states, tabCount, num);
            tabCount = 0;
            while (states[tabCount] != null)
            {
                tabCount++;
            }
            refreshFields(enterChangeBox1, states, tabCount);
            refreshFields(enterChangeBox, states, tabCount);
        }

        private void findCapitalBtn_Click(object sender, EventArgs e)
        {
            string text = findBox1.Text;
            State[] statesTemp = new State[tabCount];
            int j = 0;
            for (int i = 0; i < tabCount; i++)
            {
                if (states[i].Capital == text)
                {
                    statesTemp[j] = states[i];
                    j++;
                }
            }
            refreshFields(enterChangeBox1, statesTemp, j);
        }

        private void findAreaBtn_Click(object sender, EventArgs e)
        {
            long num = Int64.Parse(findAreaBox.Text);
            State[] statesTemp = new State[tabCount];
            int j = 0;
            for (int i = 0; i < tabCount; i++)
            {
                if (states[i].Area > num)
                {
                    statesTemp[j] = states[i];
                    j++;
                }
            }
            refreshFields(enterChangeBox1, statesTemp, j);
        }

        private void findNameBtn_Click(object sender, EventArgs e)
        {
            string text = findNameBox.Text;
            State[] statesTemp = new State[tabCount];
            int j = 0;
            for (int i = 0; i < tabCount; i++)
            {
                if (states[i].Countrname == text)
                {
                    statesTemp[j] = states[i];
                    j++;
                }
            }
            refreshFields(enterChangeBox1, statesTemp, j);
        }



        //Section3

        
        
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
                        states[tabCount] = new State(reader.ReadString(), reader.ReadString(), reader.ReadString(), reader.ReadInt64(), reader.ReadInt64());
                        states = addArr(states, curCount);
                        curCount++;
                        tabCount++;
                    }
                }
                catch (Exception s)
                {
                    MessageBox.Show(s.Message);
                }
                refreshFields(enterChangeBox, states, tabCount);
            }
        }



        //Functions

        

        static bool passCheck()
        {
            Form2 testDialog = new Form2();
            testDialog.ShowDialog();
            if (testDialog.textpassbox.Text != "password")
            {
                MessageBox.Show("Wrong password");
                return false;
            }
            else return true;
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

        static void massDelArr(State[] arr, int count, long numEnter)
        {
            State[] statesTemp = new State[count];
            int counter = 0, c = 0;
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (arr[j].Population >= numEnter)
                    {
                        if (counter == i)
                        {
                            statesTemp[i] = arr[j];
                            break;
                        }
                        counter++;
                    }
                }
                counter = 0;
            }
            Array.Clear(arr, 0, count);
            while (statesTemp[c] != null)
            {
                Console.WriteLine(c);
                arr[c] = statesTemp[c];
                c++;
            }
        }


        private void refreshFields(DataGridView enterChange , State[] arr, int count)
        {
            for (int i = 0; i < enterChange.Rows.Count - 1; i++)
            {
                enterChange.Rows.RemoveAt(i);
            }
            for (int i = 0; i < count; i++)
            {
                enterChange.Rows.Add();
                enterChange.Rows[i].Cells[0].Value = i + 1;
                enterChange.Rows[i].Cells[1].Value = arr[i].Countrname;
                enterChange.Rows[i].Cells[2].Value = arr[i].Capital;
                enterChange.Rows[i].Cells[3].Value = arr[i].Continent;
                enterChange.Rows[i].Cells[4].Value = arr[i].Population;
                enterChange.Rows[i].Cells[5].Value = arr[i].Area;
            }
        }
    }
}
