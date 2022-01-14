using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;

namespace Loki_Cheat_Sheet
{


    public partial class Form1 : Form
    {


        public Form1()
        {

            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            label1.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.BackColor = Color.DarkGray;
                this.TopMost = true;
            }
            else if (checkBox1.Checked == false)
            {
                checkBox1.BackColor = Color.Empty;
                this.TopMost = false;
            }
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {


            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {

            int YourMax = 12;
            if (listbox1.Items.Count < YourMax)
            {
                //Add item
                label1.Hide();
                string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                int i;
                for (i = 0; i < s.Length; i++)
                    listbox1.Items.Add(s[i]);

                string input1 = listbox1.Items[0].ToString();
                int index1 = input1.LastIndexOf('\\');
                int index2 = input1.IndexOf('.');
                input1 = input1.Substring(index1 + 1, index2 - index1 - 1);
                button2.Text = input1;
                button2.Enabled = true;

                string input2 = listbox1.Items[1].ToString();
                int index3 = input2.LastIndexOf('\\');
                int index4 = input2.IndexOf('.');
                input2 = input2.Substring(index3 + 1, index4 - index3 - 1);
                button3.Text = input2;
                button3.Enabled = true;

                string input3 = listbox1.Items[2].ToString();
                int index5 = input3.LastIndexOf('\\');
                int index6 = input3.IndexOf('.');
                input3 = input3.Substring(index5 + 1, index6 - index5 - 1);
                button4.Text = input3;
                button4.Enabled = true;

                string input4 = listbox1.Items[3].ToString();
                int index7 = input4.LastIndexOf('\\');
                int index8 = input4.IndexOf('.');
                input4 = input4.Substring(index7 + 1, index8 - index7 - 1);
                button5.Text = input4;
                button5.Enabled = true;

                string input5 = listbox1.Items[4].ToString();
                int index9 = input5.LastIndexOf('\\');
                int index10 = input5.IndexOf('.');
                input5 = input5.Substring(index9 + 1, index10 - index9 - 1);
                button9.Text = input5;
                button9.Enabled = true;

                string input6 = listbox1.Items[5].ToString();
                int index11 = input6.LastIndexOf('\\');
                int index12 = input6.IndexOf('.');
                input6 = input6.Substring(index11 + 1, index12 - index11 - 1);
                button8.Text = input6;
                button8.Enabled = true;

                string input7 = listbox1.Items[6].ToString();
                int index13 = input7.LastIndexOf('\\');
                int index14 = input7.IndexOf('.');
                input7 = input7.Substring(index13 + 1, index14 - index13 - 1);
                button7.Text = input7;
                button7.Enabled = true;

                string input8 = listbox1.Items[7].ToString();
                int index15 = input8.LastIndexOf('\\');
                int index16 = input8.IndexOf('.');
                input8 = input8.Substring(index15 + 1, index16 - index15 - 1);
                button6.Text = input8;
                button6.Enabled = true;

                string input9 = listbox1.Items[8].ToString();
                int index17 = input9.LastIndexOf('\\');
                int index18 = input9.IndexOf('.');
                input9 = input9.Substring(index17 + 1, index18 - index17 - 1);
                button13.Text = input9;
                button13.Enabled = true;

                string input10 = listbox1.Items[9].ToString();
                int index19 = input10.LastIndexOf('\\');
                int index20 = input10.IndexOf('.');
                input10 = input10.Substring(index19 + 1, index20 - index19 - 1);
                button12.Text = input10;
                button12.Enabled = true;

                string input11 = listbox1.Items[10].ToString();
                int index21 = input11.LastIndexOf('\\');
                int index22 = input11.IndexOf('.');
                input11 = input11.Substring(index21 + 1, index22 - index21 - 1);
                button11.Text = input11;
                button11.Enabled = true;

                string input12 = listbox1.Items[11].ToString();
                int index23 = input12.LastIndexOf('\\');
                int index24 = input12.IndexOf('.');
                input12 = input12.Substring(index23 + 1, index24 - index23 - 1);
                button10.Text = input12;
                button10.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listbox1.Items.Clear();
            button2.Text = "----------";
            button3.Text = "----------";
            button4.Text = "----------";
            button5.Text = "----------";
            button6.Text = "----------";
            button7.Text = "----------";
            button8.Text = "----------";
            button9.Text = "----------";
            button10.Text = "----------";
            button11.Text = "----------";
            button12.Text = "----------";
            button13.Text = "----------";
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            label1.Show();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                string fileName = listbox1.SelectedItems[0].ToString();
                Process.Start(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + "\n" + "oops, i cannot open this file, please provide a new link");
                label1.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e) //button start
        {

            try
            {
                string fileName = listbox1.Items[0].ToString();
                Process.Start(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + "\n" + "if I can't find your shortcut path, feed me the Original!!!");
                label1.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = listbox1.Items[1].ToString();
                Process.Start(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + "\n" + "if I can't find your shortcut path, feed me the Original!!!");
                label1.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = listbox1.Items[2].ToString();
                Process.Start(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + "\n" + "if I can't find your shortcut path, feed me the Original!!!");
                label1.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = listbox1.Items[3].ToString();
                Process.Start(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + "\n" + "if I can't find your shortcut path, feed me the Original!!!");
                label1.Show();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = listbox1.Items[4].ToString();
                Process.Start(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + "\n" + "if I can't find your shortcut path, feed me the Original!!!");
                label1.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = listbox1.Items[5].ToString();
                Process.Start(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + "\n" + "if I can't find your shortcut path, feed me the Original!!!");
                label1.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = listbox1.Items[6].ToString();
                Process.Start(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + "\n" + "if I can't find your shortcut path, feed me the Original!!!");
                label1.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = listbox1.Items[7].ToString();
                Process.Start(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + "\n" + "if I can't find your shortcut path, feed me the Original!!!");
                label1.Show();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = listbox1.Items[8].ToString();
                Process.Start(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + "\n" + "if I can't find your shortcut path, feed me the Original!!!");
                label1.Show();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = listbox1.Items[9].ToString();
                Process.Start(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + "\n" + "if I can't find your shortcut path, feed me the Original!!!");
                label1.Show();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = listbox1.Items[10].ToString();
                Process.Start(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + "\n" + "if I can't find your shortcut path, feed me the Original!!!");
                label1.Show();
            }
        }

        private void button10_Click(object sender, EventArgs e) // button end
        {
            try
            {
                string fileName = listbox1.Items[11].ToString();
                Process.Start(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + "\n" + "if I can't find your shortcut path, feed me the Original!!!");
                label1.Show();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

            Process.Start("calc.exe");

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Process.Start("https://codebeautify.org/");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void button18_Click(object sender, EventArgs e)
        {

            Process.Start("explorer.exe");
        }

        private void button19_Click(object sender, EventArgs e)
        {

            

            try
            {
                string path = Environment.CurrentDirectory + "\\" + "Loki.txt";
               
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                if (listbox1.Items.Count > 0)
                {
                   
                     SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                     saveFileDialog1.InitialDirectory = Application.StartupPath;
                     saveFileDialog1.Title = "Loki";
                     saveFileDialog1.CheckPathExists = true;
                     saveFileDialog1.DefaultExt = "txt";
                     saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                     saveFileDialog1.FilterIndex = 2;
                     saveFileDialog1.RestoreDirectory = true;
                     saveFileDialog1.FileName = "Loki";
                   
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                      
                    }
                        string route = Application.StartupPath + ("\\");  
                      StreamWriter writer = new StreamWriter(saveFileDialog1.FileName);
                    
                      for (int i = 0; i < listbox1.Items.Count; i++)
                   
                       {
                            writer.WriteLine((string)listbox1.Items[i]);
                       }
                    
                    writer.Close();
                    saveFileDialog1.Dispose();
                    
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + "\n" + "this isnt working");
            }  
        }
        

        private void button20_Click(object sender, EventArgs e)
        {
            
                try
                {
                    label1.Hide();
                    FileInfo file = new FileInfo("Loki.txt");
                    StreamReader stRead = file.OpenText();
                    while (!stRead.EndOfStream)
                    {
                        listbox1.Items.Add(stRead.ReadLine());
                    }
                    stRead.Close();
                }

                catch (Exception ex) { }
                try
                {
                    string input1 = listbox1.Items[0].ToString();
                    int index1 = input1.LastIndexOf('\\');
                    int index2 = input1.IndexOf('.');
                    input1 = input1.Substring(index1 + 1, index2 - index1 - 1);
                    button2.Text = input1;
                    button2.Enabled = true;
                }
                catch (Exception ex) { }

                try
                {
                    string input2 = listbox1.Items[1].ToString();
                    int index3 = input2.LastIndexOf('\\');
                    int index4 = input2.IndexOf('.');
                    input2 = input2.Substring(index3 + 1, index4 - index3 - 1);
                    button3.Text = input2;
                    button3.Enabled = true;
                }
                catch (Exception ex) { }

                try
                {
                    string input3 = listbox1.Items[2].ToString();
                    int index5 = input3.LastIndexOf('\\');
                    int index6 = input3.IndexOf('.');
                    input3 = input3.Substring(index5 + 1, index6 - index5 - 1);
                    button4.Text = input3;
                    button4.Enabled = true;
                }
                catch (Exception ex) { }

                try
                {
                    string input4 = listbox1.Items[3].ToString();
                    int index7 = input4.LastIndexOf('\\');
                    int index8 = input4.IndexOf('.');
                    input4 = input4.Substring(index7 + 1, index8 - index7 - 1);
                    button5.Text = input4;
                    button5.Enabled = true;
                }
                catch (Exception ex) { }

                try
                {
                    string input5 = listbox1.Items[4].ToString();
                    int index9 = input5.LastIndexOf('\\');
                    int index10 = input5.IndexOf('.');
                    input5 = input5.Substring(index9 + 1, index10 - index9 - 1);
                    button9.Text = input5;
                    button9.Enabled = true;
                }
                catch (Exception ex) { }

                try
                {
                    string input6 = listbox1.Items[5].ToString();
                    int index11 = input6.LastIndexOf('\\');
                    int index12 = input6.IndexOf('.');
                    input6 = input6.Substring(index11 + 1, index12 - index11 - 1);
                    button8.Text = input6;
                    button8.Enabled = true;
                }
                catch (Exception ex) { }

                try
                {
                    string input7 = listbox1.Items[6].ToString();
                    int index13 = input7.LastIndexOf('\\');
                    int index14 = input7.IndexOf('.');
                    input7 = input7.Substring(index13 + 1, index14 - index13 - 1);
                    button7.Text = input7;
                    button7.Enabled = true;
                }
                catch (Exception ex) { }

                try
                {
                    string input8 = listbox1.Items[7].ToString();
                    int index15 = input8.LastIndexOf('\\');
                    int index16 = input8.IndexOf('.');
                    input8 = input8.Substring(index15 + 1, index16 - index15 - 1);
                    button6.Text = input8;
                    button6.Enabled = true;
                }
                catch (Exception ex) { }

                try
                {
                    string input9 = listbox1.Items[8].ToString();
                    int index17 = input9.LastIndexOf('\\');
                    int index18 = input9.IndexOf('.');
                    input9 = input9.Substring(index17 + 1, index18 - index17 - 1);
                    button13.Text = input9;
                    button13.Enabled = true;
                }
                catch (Exception ex) { }

                try
                {
                    string input10 = listbox1.Items[9].ToString();
                    int index19 = input10.LastIndexOf('\\');
                    int index20 = input10.IndexOf('.');
                    input10 = input10.Substring(index19 + 1, index20 - index19 - 1);
                    button12.Text = input10;
                    button12.Enabled = true;
                }
                catch (Exception ex) { }

                try
                {
                    string input11 = listbox1.Items[10].ToString();
                    int index21 = input11.LastIndexOf('\\');
                    int index22 = input11.IndexOf('.');
                    input11 = input11.Substring(index21 + 1, index22 - index21 - 1);
                    button11.Text = input11;
                    button11.Enabled = true;
                }
                catch (Exception ex) { }

                try
                {
                    string input12 = listbox1.Items[11].ToString();
                    int index23 = input12.LastIndexOf('\\');
                    int index24 = input12.IndexOf('.');
                    input12 = input12.Substring(index23 + 1, index24 - index23 - 1);
                    button10.Text = input12;
                    button10.Enabled = true;
                }

                catch (Exception ex)
                {

                    Process[] ps = Process.GetProcessesByName("notepad.exe");
                    foreach (Process p in ps)
                        p.Kill();
                }

        }
        private void button16_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://wiki.cheatengine.org/index.php?title=Main_Page");
        }

        
    }


}

