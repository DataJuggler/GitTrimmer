
#region using statements

using DataJuggler.Core.UltimateHelper;
using DataJuggler.Core.UltimateHelper.Objects;
using DataJuggler.Win.Controls;
using DataJuggler.Win.Controls.Interfaces;
using DataJuggler.Win.Controls.Enumerations;
using GitTrimmer.Enumerations;
using GitTrimmer.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#endregion

namespace GitTrimmer
{

    #region class MainForm
    /// <summary>
    /// This is the main form for this application.
    /// </summary>
    public partial class MainForm : Form, ITextChanged
    {

        #region Private Variables
        private int leftMargin;
        private int rightMargin;
        private int topMargin;
        private int bottomMargin;
        private Project project;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Events

            #region Button_Enter(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Button _ Enter
            /// </summary>
            private void Button_Enter(object sender, EventArgs e)
            {
                // Change the cursor to a hand
                Cursor = Cursors.Hand;
            }
            #endregion
            
            #region Button_Leave(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Button _ Leave
            /// </summary>
            private void Button_Leave(object sender, EventArgs e)
            {
                // Change the cursor back to the default pointer
                Cursor = Cursors.Default;
            }
            #endregion
            
            #region MainForm_Activated(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Main Form _ Activated
            /// </summary>
            private void MainForm_Activated(object sender, EventArgs e)
            {
                // Set Focus To The TextBox
                ProjectRootControl.TextBox.Focus();
            }
            #endregion
            
            #region MoveButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'MoveButton' is clicked.
            /// </summary>
            private void MoveButton_Click(object sender, EventArgs e)
            {
                // if the Project.OrphanFiles exists and has at least one item
                if ((HasProject) && (ListHelper.HasOneOrMoreItems(Project.OrphanFiles)))
                {
                    // if the Project.ExternalFolder exists
                    if ((Project.HasExternalFolder) && (Directory.Exists(Project.ExternalFolder)))
                    {
                        // Setup the Progress Bar
                        Graph.Minimum = 0;
                        Graph.Value = 0;
                        Graph.Maximum = Project.OrphanFiles.Count;

                        // iterate the orphan files
                        foreach (ProjectFile file in Project.OrphanFiles)
                        {
                            // set the name
                            string movedFile = Path.Combine(Project.ExternalFolder, file.Name);

                            // if movedFolder
                            if (!File.Exists(movedFile))
                            {
                                // move the file
                                File.Move(file.FullPath, movedFile);
                            }

                            // increment the value of the graph
                            Graph.Value++;
                        }

                        // Show the complete image
                        CompleteImage.Visible = true;
                    }
                }
            }
            #endregion
            
            #region StartButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'StartButton' is clicked.
            /// </summary>
            private void StartButton_Click(object sender, EventArgs e)
            {
                // Add All Files In the Repo
                AddAllFiles();

                // Add Solution Files
                AddSolutionFiles();

                // Display Projects For Solutions is more accurate
                AddProjectsForSolutions();

                // Read the files for each project
                ReadProjectFiles();

                // Enable or disable controls
                UIEnable();
            }
            #endregion
            
        #endregion

        #region Methods

            #region AddAllFiles()
            /// <summary>
            /// This method Add All Files
            /// </summary>
            public void AddAllFiles()
            {
                // Get the list of files
                List<string> files = new List<string>();

                // get the root path
                string path = ProjectRootControl.Text;

                // create an object to hold the types of objects to find
                List<string> extensions = new List<string>();
                
                // add extensions to find
                extensions.Add(".jpg");
                extensions.Add(".png");

                // load the files
                FileHelper.GetFilesRecursively(path, ref files, extensions);

                // If the files collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(files))
                {
                    // Iterate the collection of string objects
                    foreach (string file in files)
                    {
                        // create a fileInfo
                        FileInfo fileInfo = new FileInfo(file);

                        // Add this file
                        FilesListBox.Items.Add(fileInfo.Name);

                        // Create a new instance of a 'ProjectFile' object.
                        ProjectFile projectFile = new ProjectFile();

                        // Set the FullPath
                        projectFile.FullPath = fileInfo.FullName;

                        // Set the name
                        projectFile.Name = fileInfo.Name;

                        // if the extension is png
                        if (fileInfo.Extension == ".png")
                        {
                            // set the ImageType
                            projectFile.ImageType = ImageTypeEnum.Png;
                        }
                        else if (fileInfo.Extension == ".jpg")
                        {
                            // set the ImageType
                            projectFile.ImageType = ImageTypeEnum.Jpeg;
                        }

                        // Set the Length
                        projectFile.Size = fileInfo.Length;

                        // Add this file
                        Project.AllFiles.Add(projectFile);
                    }

                    // Set the count
                    this.ItemsFoundControl.Text = files.Count.ToString();
                    this.ItemsFoundControl.Visible = true;
                    this.ItemsFoundControl.LabelColor = Color.LemonChiffon;
                }
                else
                {
                    // hide the control
                    this.ItemsFoundControl.Visible = false;
                }
            }
            #endregion

            #region AddProjectsForSolutions()
            /// <summary>
            /// This method Add Projects For Solutions
            /// </summary>
            public void AddProjectsForSolutions()
            {
                // clear the list box
                ProjectsListBox.Items.Clear();

                // Set the text
                ProjectsCountControl.Text = "0";

                // Hide this control
                ProjectsCountControl.Visible = false;

                // if the value for HasProject is true
                if (HasProject)
                {
                    // if there are one or more solutions                    
                    if (ListHelper.HasOneOrMoreItems(Project.Solutions))
                    {
                        // iterate the solutions                        
                        foreach (Solution solution in Project.Solutions)
                        {
                            // iterate the projects for each solution
                            foreach (VSProject project in solution.Projects)
                            {
                                // Add this project
                                ProjectsListBox.Items.Add(project.Name);
                            }                          
                        }

                        // set the count
                        ProjectsCountControl.Text = ProjectsListBox.Items.Count.ToString();

                        // Show this control
                        ProjectsCountControl.Visible = true;
                    }
                }
            }
            #endregion
            
            #region AddSolutionFiles()
            /// <summary>
            /// This method Adds the Solution Files
            /// </summary>
            public void AddSolutionFiles()
            {
                // Create a new instance of a 'Project' object.
                this.Project.Solutions = new List<Solution>();

                // Get the list of files
                List<string> files = new List<string>();

                // get the root path
                string path = ProjectRootControl.Text;

                // create an object to hold the types of objects to find
                List<string> solutionFiles = new List<string>();
                
                // add extensions to find
                solutionFiles.Add(".sln");
                
                // load the files
                FileHelper.GetFilesRecursively(path, ref files, solutionFiles);

                // If the files collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(files))
                {
                    // Iterate the collection of string objects
                    foreach (string file in files)
                    {
                        // create a fileInfo
                        FileInfo fileInfo = new FileInfo(file);

                        // create a solution
                        Solution solution = new Solution();

                        // Set the full path
                        solution.Path = file;

                        // Parse the projects
                        solution.Projects = ParseProjects(solution);

                        // Add this solution
                        Project.Solutions.Add(solution);

                        // Add this file
                        SolutionsListBox.Items.Add(fileInfo.Name);
                    }

                    // Set the count
                    this.SolutionsCountControl.Text = files.Count.ToString();
                    this.SolutionsCountControl.Visible = true;
                }
                else
                {
                    // hide the control
                    this.SolutionsCountControl.Text = "";
                }
            }
            #endregion
            
            #region GetProjectIndex(Guid id)
            /// <summary>
            /// This method returns the Project Index
            /// </summary>
            public int GetProjectIndex(Guid id)
            {
                // initial value
                int projectIndex = -1;

                // local
                int index = -1;

                // if the Project exists and the Project has one or more Solutions
                if ((HasProject) && (Project.HasSolutions))
                {   
                    // iterate the solutions
                    foreach (Solution solution in Project.Solutions)
                    {
                        // if there are one or more Projects
                        if (solution.HasProjects)   
                        {
                            // iterate the Projects
                            foreach (VSProject project in solution.Projects)
                            {
                                // Increment the value for index
                                index++;

                                // if the projectId matches the ones passed in
                                if (project.Id == id)
                                {
                                    // set the projectIndex
                                    projectIndex = index;

                                    // break out of the loop
                                    break;
                                }
                            }
                        }
                    }
                }
                
                // return value
                return projectIndex;
            }
            #endregion
            
            #region Init()
            /// <summary>
            /// This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Set the default value of the margin panels
                this.LeftMargin = 16;
                this.TopMargin = 16;
                this.RightMargin = 16;
                this.BottomMargin = 16;

                // add any initialization code here
                ProjectRootControl.ButtonImage = Properties.Resources.Black_Button;
                ProjectRootControl.LabelColor = Color.LemonChiffon;
                ProjectRootControl.LabelWidth = 160;
                ProjectRootControl.LabelText = "Project Root:";
                
                // Set Focus To Project Root Control
                ProjectRootControl.Editable = true;
                ProjectRootControl.TextBox.Enabled = true;
                ProjectRootControl.TextBox.Focus();

                // Setup the Listeners
                ProjectRootControl.OnTextChangedListener = this;
                ExternalFolderControl.OnTextChangedListener = this;

                // Hide until button click
                ItemsFoundControl.Visible = false;

                // Create a new instance of a 'Project' object.
                Project = new Project();

                // Enable or disable controls
                UIEnable();
            }
            #endregion

            #region OnTextChanged(Control control, string text);
            /// <summary>
            /// The Selected has changed.
            /// </summary>
            /// <param name="control"></param>
            /// <param name="selectedIndex"></param>
            public void OnTextChanged(Control control, string text)
            {  
                // cast the control as a LabelTextBoxBrowser control
                LabelTextBoxBrowserControl sender = control as LabelTextBoxBrowserControl;

                // If the sender object exists
                if ((NullHelper.Exists(sender)) && (HasProject))
                {
                    // determine the action by the name                    
                    switch(sender.Name)
                    {
                        case "ProjectRootControl":

                            // Set the RootFolder
                            Project.RootFolder = ProjectRootControl.Text;

                            // requiered
                            break;

                        case "ExternalFolderControl":

                            // Set the ExternalFolder
                            Project.ExternalFolder = ExternalFolderControl.Text;

                            // Set the Count
                            this.OrphanFilesControl.Text = Project.OrphanFiles.Count.ToString();

                            // get the size
                            long bytes = Project.OrphanFiles.Sum(x => x.Size);

                            // Set the text
                            this.SpaceSavedControl.Text = String.Format("{0:n0}", bytes) + " bytes"; 

                            // required
                            break;
                    }

                    // Enable or disable controls
                    UIEnable();
                }
            }
            #endregion

            #region ParseProjects(Solution solution)
            /// <summary>
            /// This method Parse Projects
            /// </summary>
            public List<VSProject> ParseProjects(Solution solution)
            {
                // initial value
                List<VSProject> projects = new List<VSProject>();

                  // typical delimiter characters
                char[] commaDelimiter = { ',' };
                
                // If the solutionFilePath string exists
                if ((NullHelper.Exists(solution)) && (File.Exists(solution.Path)))
                {
                    // read the text of the file
                    string fileText = File.ReadAllText(solution.Path);

                    // parse the textLines
                    List<TextLine> lines = WordParser.GetTextLines(fileText);

                    // If the lines collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(lines))
                    {
                        // get the projectLines
                        List<TextLine> projectLines = lines.Where(x => x.Text.StartsWith("Project")).Where(x => x.Text.Contains(".csproj")).ToList();

                        // if there are one or more projectLines
                        if (ListHelper.HasOneOrMoreItems(projectLines))
                        {
                            // Iterate the collection of TextLine objects
                            foreach (TextLine line in projectLines)
                            {
                                // if the line.Text exists
                                if (TextHelper.Exists(line.Text))
                                {
                                    // get the equalSignIndex
                                    int equalSignIndex = line.Text.IndexOf("=");

                                    // if the EqualSignIndex exists
                                    if (equalSignIndex >= 0)
                                    {
                                        // get the text of the word on the right side of the equal sign
                                        string wordsOnRightSideOfEqualSign = line.Text.Substring(equalSignIndex + 1).Trim();

                                        // If the wordsOnRightSideOfEqualSign string exists
                                        if (TextHelper.Exists(wordsOnRightSideOfEqualSign))
                                        {
                                            // get the words
                                            List<Word> words = WordParser.GetWords(wordsOnRightSideOfEqualSign, commaDelimiter);  

                                            // if there are at least two words
                                            if ((words != null) && (words.Count >= 3))
                                            {
                                                // create a project
                                                VSProject project = new VSProject();
                                                
                                                // get the text
                                                string projectPath = words[1].Text.Substring(2, words[1].Text.Length - 3);

                                                // Create a directory
                                                DirectoryInfo directory = new DirectoryInfo(solution.Path);

                                                // combine the solutoin and the path
                                                string path = Path.Combine(directory.Parent.FullName , projectPath);

                                                // set the path
                                                project.Path = path;

                                                // Get the projectName
                                                project.Name = words[0].Text.Replace("\"", "");

                                                // set the solution
                                                project.Solution = solution;

                                                string temp = words[2].Text.Substring(2, words[2].Text.Length - 3).Replace(@"\", "").Replace("{", "").Replace("}", "").Trim();

                                                // get the tempId
                                                Guid tempId = Guid.Empty;

                                                // parse the Guid
                                                Guid.TryParse(temp, out tempId);

                                                // set the projectId
                                                project.Id = tempId;

                                                // now find the index of this project so the same project is not added twice
                                                int index = GetProjectIndex(project.Id);

                                                // if the index was found
                                                if (index < 0)
                                                {
                                                    // Add this project
                                                    projects.Add(project);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                // return value
                return projects;
            }
            #endregion
            
            #region ReadProjectFiles()
            /// <summary>
            /// This method returns the Project Files
            /// </summary>
            public int ReadProjectFiles()
            {
                // initial value
                int count = 0;

                // clear the list box
                ProjectFilesListBox.Items.Clear();

                // if the value for HasProject is true
                if ((HasProject) && (Project.HasSolutions))
                {
                    // iterate the solutions
                    foreach (Solution solution in Project.Solutions)
                    {
                        // If the value for the property solution.HasProjects is true
                        if (solution.HasProjects)
                        {
                            // iterate the solutions
                            foreach (VSProject project in solution.Projects)
                            {
                                // Create a new instance of a 'DirectoryInfo' object.
                                DirectoryInfo directory = new DirectoryInfo(project.Path);

                                // Create a new collection of 'ProjectFile' objects.
                                project.Files = new List<ProjectFile>();

                                // if the project has a path and the path exists on the disk
                                if ((project.HasPath) && (File.Exists(project.Path)))
                                {   
                                      // read the text of the file
                                    string fileText = File.ReadAllText(project.Path);

                                    // parse the textLines
                                    List<TextLine> lines = WordParser.GetTextLines(fileText);

                                    // If the lines collection exists and has one or more items
                                    if (ListHelper.HasOneOrMoreItems(lines))
                                    {
                                        // get the lines that contain include and either .jpg or .png
                                        lines = lines.Where(x => x.Text.Contains("Include=") && (x.Text.Contains(".jpg")) || (x.Text.Contains(".png"))).ToList();

                                        // iterate the collection of lines
                                        if (ListHelper.HasOneOrMoreItems(lines))
                                        {
                                            // Iterate the collection of string objects
                                            foreach (TextLine line in lines)
                                            {
                                                // create a projectFile
                                                ProjectFile projectFile = new ProjectFile();

                                                // if this line is considered content
                                                projectFile.IsContent = line.Text.Contains("Content");

                                                // get the index of Include=
                                                int index = line.Text.IndexOf("Include=");
                                                
                                                // if the index exists
                                                if (index >= 0)
                                                {
                                                    // get the tempPath
                                                    string tempPath = line.Text.Substring(index + 9, line.Text.Length - index - 8 - 4 - 1);
                                                
                                                    // now build the FullPath
                                                    projectFile.FullPath = Path.Combine(directory.Parent.FullName, tempPath);

                                                    // if the file exists
                                                    if (File.Exists(projectFile.FullPath))
                                                    {
                                                        // Create a new instance of a 'FileInfo' object.
                                                        FileInfo fileInfo = new FileInfo(projectFile.FullPath);

                                                        // set the name
                                                        projectFile.Name = fileInfo.Name;

                                                        // set the size
                                                        projectFile.Size = fileInfo.Length;

                                                        // add this file
                                                        project.Files.Add(projectFile);

                                                        // Add this item
                                                        ProjectFilesListBox.Items.Add(projectFile.Name);
                                                    
                                                        // increment count
                                                        count++;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                // display the count
                ProjectImagesCountControl.Text = count.ToString();

                // display the count
                this.Refresh();
                
                // return value
                return count;
            }
            #endregion
            
            #region UIEnable()
            /// <summary>
            /// This method UI Enable
            /// </summary>
            public void UIEnable()
            {
                // locals
                bool enableStart = false;
                bool enableMove = false;

                // Enable the start button
                if ((HasProject) && (Project.HasRootFolder))
                {
                    // enable the start button
                    enableStart = true;
                }

                // if both the RootFolder and ExternalFolders exist and there are one or more ExternalFolders
                if ((HasProject) && (Project.HasExternalFolder) && (ListHelper.HasOneOrMoreItems(Project.OrphanFiles)))
                {
                    // set to true
                    enableMove = true;
                }

                // Enable the StartButton if we have a RootFolder and an ExternalFolder
                StartButton.Enabled = enableStart;
                MoveButton.Enabled = enableMove;

                // Refresh everything
                Refresh();
            }
            #endregion
            
        #endregion

        #region Properties

            #region BottomMargin
            /// <summary>
            /// This property gets or sets the value for 'BottomMargin'.
            /// </summary>
            public int BottomMargin
            {
                get { return bottomMargin; }
                set
                {
                    // set the value
                    bottomMargin = value;

                    // set the value of the control
                    BottomMarginPanel.Height = bottomMargin;
                }
            }
            #endregion

            #region CreateParams
            /// <summary>
            /// This property here is what did the trick to reduce the flickering.
            /// I also needed to make all of the controls Double Buffered, but
            /// this was the final touch. It is a little slow when you switch tabs
            /// but that is because the repainting is finishing before control is
            /// returned.
            /// </summary>
            protected override CreateParams CreateParams
            {
                get
                {
                    // initial value
                    CreateParams cp = base.CreateParams;

                    // Apparently this interrupts Paint to finish before showing
                    cp.ExStyle |= 0x02000000;

                    // return value
                    return cp;
                }
            }
            #endregion

            #region HasProject
            /// <summary>
            /// This property returns true if this object has a 'Project'.
            /// </summary>
            public bool HasProject
            {
                get
                {
                    // initial value
                    bool hasProject = (this.Project != null);
                    
                    // return value
                    return hasProject;
                }
            }
            #endregion
            
            #region LeftMargin
            /// <summary>
            /// This property gets or sets the value for 'LeftMargin'.
            /// </summary>
            public int LeftMargin
            {
                get { return leftMargin; }
                set
                {
                    // set the value
                    leftMargin = value;

                    // set the value of the control
                    LeftMarginPanel.Width = leftMargin;
                }
            }
            #endregion

            #region Project
            /// <summary>
            /// This property gets or sets the value for 'Project'.
            /// </summary>
            public Project Project
            {
                get { return project; }
                set { project = value; }
            }
            #endregion
            
            #region RightMargin
            /// <summary>
            /// This property gets or sets the value for 'RightMargin'.
            /// </summary>
            public int RightMargin
            {
                get { return rightMargin; }
                set
                {
                    // set the value
                    rightMargin = value;

                    // set the width of the control
                    RightMarginPanel.Width = rightMargin;
                }
            }
            #endregion

            #region TopMargin
            /// <summary>
            /// This property gets or sets the value for 'TopMargin'.
            /// </summary>
            public int TopMargin
            {
                get { return topMargin; }
                set
                {
                    // set the value
                    topMargin = value;

                    // set the height of the control
                    TopMarginPanel.Height = topMargin;
                }
            }
            #endregion

        #endregion

    }
    #endregion

}
