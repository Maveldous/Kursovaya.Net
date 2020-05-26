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
using System.Net.Http;

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

        private void appendBtn_Click(object sender, EventArgs e)
        {

            if (enterBoxName.Text != "" && enterBoxCapital.Text != "" && enterBoxContinent.Text != "" && enterLongCheck(enterBoxPopulation.Text) && enterLongCheck(enterBoxArea.Text))
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
            else MessageBox.Show("Не все поля заполнены или заполнены некоректно!");

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if(passCheck() && enterIntCheck(enterDelBox.Text, tabCount))
            {
                DelArr(states, curCount, Int32.Parse(enterDelBox.Text));
                curCount--;
                tabCount--;
                refreshFields(enterChangeBox, states, tabCount);
                enterDelBox.Clear();
            }
            else MessageBox.Show("Введены некоректные значения!");
        }
        private void changeBtn_Click(object sender, EventArgs e)
        {
            if (passCheck() && enterIntCheck(changeBox.Text, tabCount) && changeBox1.Text != "")
            {
                int num = Int32.Parse(changeBox.Text);
                string field = changeBox1.Text;
                string value = changeBox2.Text;
                states[num - 1].Change(field, value);
                refreshFields(enterChangeBox, states, tabCount);
            }
            else MessageBox.Show("Введены некоректные значения!");
        }

        //Section2


        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            refreshFields(enterChangeBox1, states, tabCount);
        }

        private void massDelBtn_Click(object sender, EventArgs e)
        {
            if (passCheck() && enterLongCheck(populDelBox.Text))
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
            else MessageBox.Show("Введены некоректные значения!");
        }

        private void findCapitalBtn_Click(object sender, EventArgs e)
        {
            if(findBox1.Text != "")
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
            else MessageBox.Show("Пустое поле для ввода");
        }

        private void findAreaBtn_Click(object sender, EventArgs e)
        {
            if (enterLongCheck(findAreaBox.Text))
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
            else MessageBox.Show("Введены некоректные значения!");
        }

        private void findNameBtn_Click(object sender, EventArgs e)
        {
            if(findNameBox.Text != "")
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
            else MessageBox.Show("Пустое поле для ввода");
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

        private void refBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("opera.exe", "file:///C:/Users/User/Source/Repos/Kursach/WindowsFormsApp1/WindowsFormsApp1/ref.html");
        }



        //Functions


        
        static bool enterIntCheck(string value, int count)
        {
            if (value.Any(c => char.IsLetter(c)))
            {
                return false;
            }
            if (value == "" || Int32.Parse(value) <= 0 || Int32.Parse(value) > count)
                return false;
            else
                return true;
        }


        public bool enterLongCheck(string value)
        {
            if (value.Any(c => char.IsLetter(c)) || value == "" || Int64.Parse(value) <= 0 || Int64.Parse(value) > 10000000)
                return false;        
            else
                return true;
        }

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
            for (int i = 0; i < enterChange.Rows.Count; i++)
            {
                enterChange.Rows.Clear();
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
