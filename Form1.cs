using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Test1 : Form
    {
        private readonly Project defaultProject;
        private Stack<Project> recentProjects;
        private List<ToolStripMenuItem> recentFileMenuItems;
        private int numberOfRecentFiles { get; set; } = 5;
        private const string RECENTFILESPATH = "recentFiles.bin";
        private const string DEFAULTPROJECTPATH = "config.txt";


        public Test1()
        {
            recentProjects = new Stack<Project>(numberOfRecentFiles);
            recentFileMenuItems = new List<ToolStripMenuItem>();
            defaultProject = new Project()
            {
                Name = "Project 1",
                Description = "Write about project...",
                FolderPath = Directory.GetCurrentDirectory(),
                StartDate = DateTime.Today,
                EndDate = DateTime.Now.AddDays(2),
                ProjectType = "Simple",
                MaxNumberOfResults = 1,
                EnableNotifications = true
            };
            InitializeComponent();
        }

        public void ReadLinesFromFile(string FilePath)
        {
            if(FilePath == DEFAULTPROJECTPATH)
            {
                using (StreamReader stream = new StreamReader(FilePath))
                {
                    using (StringReader reader = new StringReader(stream.ReadToEnd()))
                    {
                        nameTb.Text = reader.ReadLine();
                        descriptionTb.Text = reader.ReadLine();
                        folderpathTb.Text = reader.ReadLine();
                        projecttypeCb.Text = reader.ReadLine();
                        maxnumberresultsBox.Value = Convert.ToInt32(reader.ReadLine());
                        enablenotificationsCheckbox.Checked = Convert.ToBoolean(reader.ReadLine());
                    }
                }
            } else
            {
                using (StreamReader stream = new StreamReader(FilePath))
                {
                    using (StringReader reader = new StringReader(stream.ReadToEnd()))
                    {
                        nameTb.Text = reader.ReadLine();
                        descriptionTb.Text = reader.ReadLine();
                        folderpathTb.Text = reader.ReadLine();
                        startdateBox.Value = DateTime.Now;
                        enddateBox.Value = DateTime.Now.AddDays(2);
                        projecttypeCb.Text = reader.ReadLine();
                        maxnumberresultsBox.Value = Convert.ToInt32(reader.ReadLine());
                        enablenotificationsCheckbox.Checked = Convert.ToBoolean(reader.ReadLine());
                    }
                }
            }
        }
        public void WriteLinesInFile(Project project, String path)
        {
            if (path == DEFAULTPROJECTPATH)
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine(project.Name);
                    writer.WriteLine(project.Description);
                    writer.WriteLine(project.FolderPath);
                    writer.WriteLine(project.ProjectType);
                    writer.WriteLine(project.MaxNumberOfResults);
                    writer.WriteLine(project.EnableNotifications);
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine(project.Name);
                    writer.WriteLine(project.Description);
                    writer.WriteLine(project.FolderPath);
                    writer.WriteLine(project.StartDate);
                    writer.WriteLine(project.EndDate);
                    writer.WriteLine(project.ProjectType);
                    writer.WriteLine(project.MaxNumberOfResults);
                    writer.WriteLine(project.EnableNotifications);
                }
            }
            
        }
        public void CreateDefaultProjectFile()
        {
            FileStream fileStream = File.Create(DEFAULTPROJECTPATH);
            fileStream.Close();
            WriteLinesInFile(defaultProject, DEFAULTPROJECTPATH);
        }

        public void LoadDefaultProjectFile()
        {
            ReadLinesFromFile(DEFAULTPROJECTPATH);
        }
    

        public void CreateRecentFilesBin()
        {
            if (!File.Exists(RECENTFILESPATH))
            {
                FileStream stream = new FileStream(RECENTFILESPATH, FileMode.Create);
                stream.Close();
            }
            
        }


        public void LoadStackRecentProjacts(Stack<Project> projects)
        {
            projects.Clear();
            using (FileStream stream = new FileStream(RECENTFILESPATH, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                if (stream.Length != 0)
                {
                    Stack<Project> projectArray = new Stack<Project>();
                    projectArray = (Stack<Project>)formatter.Deserialize(stream);
                     for (int x = numberOfRecentFiles; x>0; x--)
                     {
                        if (projectArray.Count != 0)
                        {
                            projects.Push(projectArray.Pop());
                        }
                        
                     }
                }  
            }
        }
        public void FillProjectFields(ToolStripMenuItem item)
        {
             ReadLinesFromFile($"{item.Text}.txt");

        }

        public void UpdateRecentFilesBin (Stack<Project> projects)
        {
            using (FileStream stream = new FileStream(RECENTFILESPATH, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, projects);
            }
        }

        public void NewProjectFill(Project newProject)
        {
            newProject.Name = nameTb.Text;
            newProject.Description = descriptionTb.Text;
            newProject.FolderPath = folderpathTb.Text;
            newProject.StartDate = startdateBox.Value;
            newProject.EndDate = enddateBox.Value;
            newProject.ProjectType = projecttypeCb.Text;
            newProject.MaxNumberOfResults = Decimal.ToInt32(maxnumberresultsBox.Value);
            newProject.EnableNotifications = enablenotificationsCheckbox.Checked;
        }

        public void SaveButton_Click(object sender, EventArgs e)
        {
            Project newProject = new Project();
            NewProjectFill(newProject);

            if (Directory.Exists(newProject.FolderPath))
            {
                
                String filePath = $"{Path.Combine(newProject.FolderPath, newProject.Name)}.txt";

                WriteLinesInFile(newProject, filePath);

                MessageBox.Show($"Project saved in {Directory.GetParent(filePath)}");

                recentProjects.Push(newProject);
                UpdateRecentFilesMenu();
                UpdateRecentFilesBin(recentProjects);
                
            }
        }

        //Overload function
        public void SaveButton_Click(object sender, EventArgs e, String filePath)
        {
            Project newProject = new Project();
            NewProjectFill(newProject);

            if (Directory.Exists(newProject.FolderPath))
            {

                WriteLinesInFile(newProject, filePath);

                MessageBox.Show($"Project saved in {Directory.GetParent(filePath)}");

                recentProjects.Push(newProject);
                UpdateRecentFilesMenu();
                UpdateRecentFilesBin(recentProjects);
            }
        }
        public void recentFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem myItem = sender as ToolStripMenuItem;
            FillProjectFields(myItem);
        }

        public void UpdateRecentFilesMenu()
        {

            recentProjectsToolStripMenuItem.DropDownItems.Clear();
            recentFileMenuItems.Clear();

            foreach (Project project in recentProjects)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(project.Name);
                menuItem.Tag = Path.Combine(project.FolderPath, project.Name);
                menuItem.Text = Path.Combine(project.FolderPath, project.Name);
                menuItem.Click += recentFilesToolStripMenuItem_Click;
                recentProjectsToolStripMenuItem.DropDownItems.Add(menuItem);
                recentFileMenuItems.Add(menuItem);
            }

        }

        public void newButton_Click(object sender, EventArgs e)
        {
            nameTb.Text = "";
            descriptionTb.Text = "";
            folderpathTb.Text = "";
            startdateBox.Value = DateTime.Now;
            enddateBox.Value = DateTime.Now;
            projecttypeCb.Text = "";
            maxnumberresultsBox.Value = 1;
            enablenotificationsCheckbox.Checked = false;
        }

        public void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem.Click += SaveButton_Click;
        }

        public void openSaveFileDialogAndSave(object sender, EventArgs e)
        {
            SaveFileDialog dg = new SaveFileDialog();

            dg.Title = "Save File As";
            dg.DefaultExt = "txt";
            dg.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            dg.FileName = "NewProject";

            // Display the SaveFileDialog and get the user's response
            DialogResult result = dg.ShowDialog();
            

            // If the user clicked the "Save" button in the dialog box
            if (result == DialogResult.OK)
            {
                // Get the selected file name from the SaveFileDialog
                string filePath = dg.FileName;

                SaveButton_Click(sender, new EventArgs(), filePath);

            }
            else
            {
                 if (result == DialogResult.Cancel)
                {
                    dg.Dispose();
                }
            }
        }

        public void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openSaveFileDialogAndSave(sender,e);
        }

        public void cbNumRecentFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

            numberOfRecentFiles = Convert.ToInt32(cbNumRecentFiles.SelectedItem.ToString());
            LoadStackRecentProjacts(recentProjects);
            UpdateRecentFilesMenu();
        }

        public void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {
            if (!File.Exists(DEFAULTPROJECTPATH))
            {
                CreateDefaultProjectFile();
            }
            LoadDefaultProjectFile();
            CreateRecentFilesBin();

            LoadStackRecentProjacts(recentProjects);

            UpdateRecentFilesMenu();
        }

    }
}
