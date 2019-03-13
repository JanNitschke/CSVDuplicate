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
using F23.StringSimilarity;
using System.Threading;
using System.Threading.Tasks;


namespace DataCleaner
{
    public partial class Form1 : Form
    {
        string pathOrg;
        Stream orgStream;
        string[] orgHeader;
        List<string[]> orgItems;

        string pathNew;
        Stream newStream;
        string[] newHeader;
        List<string[]> newItems;

        Boolean running = false;

        Stream outStream;

        public Form1()
        {
            InitializeComponent();
        }

        private class ListItem
        {
            public string Name;
            public int Index;
            public ListItem(string name, int index)
            {
                Name = name; Index = index;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Title = "Neuen Datensatz auswählen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    var filePath = openFileDialog.FileName;
                    textBox2.Text = filePath;
                    this.pathNew = filePath;


                    var fileStream = openFileDialog.OpenFile();
                    this.newStream = fileStream;

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        var headerLine = reader.ReadLine();
                        this.newHeader = headerLine.Split(',');
                        comboBoxNew1.Items.Clear();
                        comboBoxNew2.Items.Clear();
                        int i = 0;
                        foreach (string header in this.newHeader)
                        {
                            comboBoxNew1.Items.Add(new ListItem(header, i));
                            comboBoxNew2.Items.Add(new ListItem(header, i));
                            i++;
                        }
                        this.newItems = new List<string[]>();
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            this.newItems.Add(line.Split(','));
                        }
                    }

                }
            }
        }

        private void ButtonOrg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Title = "Orginal Datensatz auswählen";


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    var filePath = openFileDialog.FileName;
                    textBox1.Text = filePath;
                    this.pathOrg = filePath;


                    var fileStream = openFileDialog.OpenFile();
                    this.orgStream = fileStream;

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        var headerLine = reader.ReadLine();
                        this.orgHeader = headerLine.Split(',');
                        comboBoxOrg1.Items.Clear();
                        comboBoxOrg2.Items.Clear();
                        int i = 0;
                        foreach (string header in this.orgHeader)
                        {
                            comboBoxOrg1.Items.Add(new ListItem(header, i));
                            comboBoxOrg2.Items.Add(new ListItem(header, i));
                            i++;
                        }
                        this.orgItems = new List<string[]>();
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            this.orgItems.Add(line.Split(','));
                        }
                    }
                }
            }
        }

        private void ComboBoxNew2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxNew1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonOut_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image  
            // assigned to Button2.  
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "CSV |*.csv";
            saveFileDialog1.Title = "Save CSV Output File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.FileName != "")
            {
                var filePath = saveFileDialog1.FileName;
                textBox3.Text = filePath;

                // Saves the Image via a FileStream created by the OpenFile method.  
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog1.OpenFile();

                outStream = fs;

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                outStream.Close();
                orgStream.Close();
                newStream.Close();

            }
            catch (Exception ex)
            {

            }

        }

        private void ButtonGo_Click(object sender, EventArgs e)
        {
        
            if (orgItems != null && newItems != null && outStream != null && (ListItem)comboBoxOrg1.SelectedItem != null && (ListItem)comboBoxNew1.SelectedItem != null && running == false)
            {
                running = true;
                Thread.CurrentThread.Name = "Main";
                ListItem ItemOrg1 = (ListItem)comboBoxOrg1.SelectedItem;
                ListItem ItemOrg2 = (ListItem)comboBoxOrg2.SelectedItem;
                ListItem ItemNew1 = (ListItem)comboBoxNew1.SelectedItem;
                ListItem ItemNew2 = (ListItem)comboBoxNew1.SelectedItem;
                double threshold = ((double)trackBar1.Value) / 100;
                progressBar1.Maximum = newItems.Count;

                var prog = new Progress<int>();
                var progfound = new Progress<int>();

                prog.ProgressChanged += (senderOfProgressChanged, nextItem) =>
                { progressBar1.Value = nextItem; if (nextItem == newItems.Count - 1) running = false; };

                progfound.ProgressChanged += (senderOfProgressChanged, nextItem) =>
                { label10.Text = "found " + nextItem + " new Entries"; };
                

                var task = Task.Run(() =>
                {
                    using (StreamWriter sw = new StreamWriter(outStream))
                    {
                        // retrive indexes
                       
                        int indexOrg1 = ItemOrg1.Index;
                        int indexNew1 = ItemNew1.Index;
                        int indexOrg2 = -1;
                        int indexNew2 = -1;
                        Console.WriteLine("th: " + threshold);
                        if (ItemNew2 != null && ItemOrg2 != null)
                        {
                            indexOrg2 = ItemOrg2.Index;
                            indexNew2 = ItemNew2.Index;
                        }

                        // comperator
                        var jw = new JaroWinkler();

                        // create header line
                        string headerLine = "";
                        foreach (string header in newHeader)
                        {
                            headerLine += "new-" + header + ",";
                        }
                        foreach (string header in orgHeader)
                        {
                            headerLine += "org-" + header + ",";
                        }
                        headerLine = headerLine.Substring(0, headerLine.Length - 1);
                        sw.WriteLine(headerLine);

                        int index = 0;
                        int found = 0;
                        int incompleteNew = 0;
                        int incompleteOrg = 0;
                        int incompleteOptional = 0;


                        foreach (string[] newItemLine in newItems)
                        {
                            if (newItemLine.Length > indexNew1)
                            {
                                string element1 = newItemLine[indexNew1];
                                string element2 = null;
                                if (indexNew2 > -1 && indexOrg2 > -1)
                                {
                                    if (newItemLine.Length > indexNew2)
                                    {
                                        element2 = newItemLine[indexNew2];
                                    }
                                    else
                                    {
                                        incompleteOptional++;
                                    }
                                }
                                string[] closest = null;
                                double closestVal = -1;

                                foreach (string[] orgItemLine in orgItems)
                                {
                                    if (orgItemLine.Length > indexOrg1)
                                    {
                                        string canidate1 = orgItemLine[indexNew1];
                                        string canidate2 = null;

                                        if (indexNew2 > -1 && indexOrg2 > -1)
                                        {
                                            if (orgItemLine.Length > indexOrg2)
                                            {
                                                canidate2 = orgItemLine[indexOrg2];
                                            }
                                            else
                                            {
                                                incompleteOptional++;
                                            }
                                        }
                                        double similarity1 = jw.Similarity(element1, canidate1);
                                        double similarity2 = 1.0;
                                        if (canidate2 != null)
                                        {
                                            similarity2 = jw.Similarity(element1, canidate2);
                                        }
                                        double similarity = similarity1 * similarity2;
                                        if (similarity > closestVal)
                                        {
                                            closestVal = similarity;
                                            closest = orgItemLine;
                                        }
                                    }
                                    else
                                    {
                                        incompleteOrg++;
                                    }
                                }

                                if (closestVal > -1 && !(closestVal > threshold))
                                {
                                    string newLine = "";

                                    foreach (string itm in newItemLine)
                                    {
                                        newLine += itm + ",";
                                    }
                                    foreach (string itm in closest)
                                    {
                                        newLine += itm + ",";
                                    }


                                    newLine = newLine.Substring(0, newLine.Length - 1);
                                    sw.WriteLine(newLine);
                                    found++;
                                    ((IProgress<int>)progfound).Report(found);
                                }
                                index++;
                                ((IProgress<int>)prog).Report(index);
                            }
                            else
                            {
                                incompleteNew++;
                            }

                        }
                        Console.Write("finished");
                    }
                });
            }
            else
            {
                Help.ShowPopup(buttonGo, "Incomplete Config", new Point(buttonGo.Right, this.buttonGo.Bottom));
            }
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            label9.Text = trackBar1.Value.ToString() + "%";
        }
    }
}
