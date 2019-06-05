namespace GitTrimmer
{
    partial class MainForm
    {

        #region Private Variables
        private System.Windows.Forms.Panel LeftMarginPanel;
        private System.Windows.Forms.Panel RightMarginPanel;
        private System.Windows.Forms.Panel BottomMarginPanel;
        private System.Windows.Forms.Panel TopMarginPanel;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        #endregion

        #region Methods

        #region Dispose
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion

        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LeftMarginPanel = new System.Windows.Forms.Panel();
            this.RightMarginPanel = new System.Windows.Forms.Panel();
            this.BottomMarginPanel = new System.Windows.Forms.Panel();
            this.TopMarginPanel = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.FilesListBox = new System.Windows.Forms.ListBox();
            this.SolutionsListBox = new System.Windows.Forms.ListBox();
            this.ProjectsListBox = new System.Windows.Forms.ListBox();
            this.ProjectFilesListBox = new System.Windows.Forms.ListBox();
            this.MoveButton = new System.Windows.Forms.Button();
            this.Graph = new System.Windows.Forms.ProgressBar();
            this.CompleteImage = new System.Windows.Forms.PictureBox();
            this.SpaceSavedControl = new DataJuggler.Win.Controls.LabelLabelControl();
            this.OrphanFilesControl = new DataJuggler.Win.Controls.LabelLabelControl();
            this.ExternalFolderControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.ProjectImagesCountControl = new DataJuggler.Win.Controls.LabelLabelControl();
            this.ProjectsCountControl = new DataJuggler.Win.Controls.LabelLabelControl();
            this.SolutionsCountControl = new DataJuggler.Win.Controls.LabelLabelControl();
            this.ItemsFoundControl = new DataJuggler.Win.Controls.LabelLabelControl();
            this.ProjectRootControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            ((System.ComponentModel.ISupportInitialize)(this.CompleteImage)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftMarginPanel
            // 
            this.LeftMarginPanel.BackColor = System.Drawing.Color.Transparent;
            this.LeftMarginPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMarginPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftMarginPanel.Name = "LeftMarginPanel";
            this.LeftMarginPanel.Size = new System.Drawing.Size(16, 715);
            this.LeftMarginPanel.TabIndex = 0;
            // 
            // RightMarginPanel
            // 
            this.RightMarginPanel.BackColor = System.Drawing.Color.Transparent;
            this.RightMarginPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightMarginPanel.Location = new System.Drawing.Point(1048, 0);
            this.RightMarginPanel.Name = "RightMarginPanel";
            this.RightMarginPanel.Size = new System.Drawing.Size(16, 715);
            this.RightMarginPanel.TabIndex = 2;
            // 
            // BottomMarginPanel
            // 
            this.BottomMarginPanel.BackColor = System.Drawing.Color.Transparent;
            this.BottomMarginPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomMarginPanel.Location = new System.Drawing.Point(16, 699);
            this.BottomMarginPanel.Name = "BottomMarginPanel";
            this.BottomMarginPanel.Size = new System.Drawing.Size(1032, 16);
            this.BottomMarginPanel.TabIndex = 4;
            // 
            // TopMarginPanel
            // 
            this.TopMarginPanel.BackColor = System.Drawing.Color.Transparent;
            this.TopMarginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopMarginPanel.Location = new System.Drawing.Point(16, 0);
            this.TopMarginPanel.Name = "TopMarginPanel";
            this.TopMarginPanel.Size = new System.Drawing.Size(1032, 16);
            this.TopMarginPanel.TabIndex = 5;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.BackgroundImage = global::GitTrimmer.Properties.Resources.Black_Button;
            this.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartButton.FlatAppearance.BorderSize = 0;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.StartButton.Location = new System.Drawing.Point(923, 112);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(100, 36);
            this.StartButton.TabIndex = 7;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            this.StartButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.StartButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // FilesListBox
            // 
            this.FilesListBox.FormattingEnabled = true;
            this.FilesListBox.ItemHeight = 18;
            this.FilesListBox.Location = new System.Drawing.Point(25, 112);
            this.FilesListBox.Name = "FilesListBox";
            this.FilesListBox.Size = new System.Drawing.Size(289, 364);
            this.FilesListBox.Sorted = true;
            this.FilesListBox.TabIndex = 8;
            // 
            // SolutionsListBox
            // 
            this.SolutionsListBox.FormattingEnabled = true;
            this.SolutionsListBox.ItemHeight = 18;
            this.SolutionsListBox.Location = new System.Drawing.Point(344, 112);
            this.SolutionsListBox.Name = "SolutionsListBox";
            this.SolutionsListBox.Size = new System.Drawing.Size(243, 130);
            this.SolutionsListBox.Sorted = true;
            this.SolutionsListBox.TabIndex = 10;
            // 
            // ProjectsListBox
            // 
            this.ProjectsListBox.FormattingEnabled = true;
            this.ProjectsListBox.ItemHeight = 18;
            this.ProjectsListBox.Location = new System.Drawing.Point(344, 310);
            this.ProjectsListBox.Name = "ProjectsListBox";
            this.ProjectsListBox.Size = new System.Drawing.Size(243, 166);
            this.ProjectsListBox.Sorted = true;
            this.ProjectsListBox.TabIndex = 12;
            // 
            // ProjectFilesListBox
            // 
            this.ProjectFilesListBox.FormattingEnabled = true;
            this.ProjectFilesListBox.ItemHeight = 18;
            this.ProjectFilesListBox.Location = new System.Drawing.Point(619, 112);
            this.ProjectFilesListBox.Name = "ProjectFilesListBox";
            this.ProjectFilesListBox.Size = new System.Drawing.Size(289, 364);
            this.ProjectFilesListBox.Sorted = true;
            this.ProjectFilesListBox.TabIndex = 14;
            // 
            // MoveButton
            // 
            this.MoveButton.BackColor = System.Drawing.Color.Transparent;
            this.MoveButton.BackgroundImage = global::GitTrimmer.Properties.Resources.Black_Button;
            this.MoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoveButton.FlatAppearance.BorderSize = 0;
            this.MoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.MoveButton.Location = new System.Drawing.Point(923, 548);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(100, 36);
            this.MoveButton.TabIndex = 19;
            this.MoveButton.Text = "Move";
            this.MoveButton.UseVisualStyleBackColor = false;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            this.MoveButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.MoveButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // Graph
            // 
            this.Graph.BackColor = System.Drawing.Color.MidnightBlue;
            this.Graph.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Graph.ForeColor = System.Drawing.Color.SteelBlue;
            this.Graph.Location = new System.Drawing.Point(16, 676);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(1032, 23);
            this.Graph.TabIndex = 20;
            this.Graph.Visible = false;
            // 
            // CompleteImage
            // 
            this.CompleteImage.BackColor = System.Drawing.Color.Transparent;
            this.CompleteImage.BackgroundImage = global::GitTrimmer.Properties.Resources.Complete;
            this.CompleteImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CompleteImage.Location = new System.Drawing.Point(728, 531);
            this.CompleteImage.Name = "CompleteImage";
            this.CompleteImage.Size = new System.Drawing.Size(160, 144);
            this.CompleteImage.TabIndex = 21;
            this.CompleteImage.TabStop = false;
            this.CompleteImage.Visible = false;
            // 
            // SpaceSavedControl
            // 
            this.SpaceSavedControl.BackColor = System.Drawing.Color.Transparent;
            this.SpaceSavedControl.Font = new System.Drawing.Font("Verdana", 12F);
            this.SpaceSavedControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.SpaceSavedControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpaceSavedControl.LabelText = "Disk Savings:";
            this.SpaceSavedControl.LabelWidth = 160;
            this.SpaceSavedControl.Location = new System.Drawing.Point(25, 582);
            this.SpaceSavedControl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SpaceSavedControl.Name = "SpaceSavedControl";
            this.SpaceSavedControl.Size = new System.Drawing.Size(313, 24);
            this.SpaceSavedControl.TabIndex = 18;
            this.SpaceSavedControl.ValueLabelColor = System.Drawing.Color.LemonChiffon;
            this.SpaceSavedControl.ValueLabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // OrphanFilesControl
            // 
            this.OrphanFilesControl.BackColor = System.Drawing.Color.Transparent;
            this.OrphanFilesControl.Font = new System.Drawing.Font("Verdana", 12F);
            this.OrphanFilesControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.OrphanFilesControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrphanFilesControl.LabelText = "Orphan Files:";
            this.OrphanFilesControl.LabelWidth = 160;
            this.OrphanFilesControl.Location = new System.Drawing.Point(25, 548);
            this.OrphanFilesControl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.OrphanFilesControl.Name = "OrphanFilesControl";
            this.OrphanFilesControl.Size = new System.Drawing.Size(222, 24);
            this.OrphanFilesControl.TabIndex = 17;
            this.OrphanFilesControl.ValueLabelColor = System.Drawing.Color.LemonChiffon;
            this.OrphanFilesControl.ValueLabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ExternalFolderControl
            // 
            this.ExternalFolderControl.BackColor = System.Drawing.Color.Transparent;
            this.ExternalFolderControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExternalFolderControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.Folder;
            this.ExternalFolderControl.ButtonImage = ((System.Drawing.Image)(resources.GetObject("ExternalFolderControl.ButtonImage")));
            this.ExternalFolderControl.ButtonWidth = 48;
            this.ExternalFolderControl.DisabledLabelColor = System.Drawing.Color.LightGray;
            this.ExternalFolderControl.Editable = false;
            this.ExternalFolderControl.EnabledLabelColor = System.Drawing.Color.LemonChiffon;
            this.ExternalFolderControl.Filter = null;
            this.ExternalFolderControl.Font = new System.Drawing.Font("Verdana", 12F);
            this.ExternalFolderControl.HideBrowseButton = false;
            this.ExternalFolderControl.LabelBottomMargin = 0;
            this.ExternalFolderControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.ExternalFolderControl.LabelFont = null;
            this.ExternalFolderControl.LabelText = "External Folder:";
            this.ExternalFolderControl.LabelTopMargin = 0;
            this.ExternalFolderControl.LabelWidth = 160;
            this.ExternalFolderControl.Location = new System.Drawing.Point(25, 508);
            this.ExternalFolderControl.Name = "ExternalFolderControl";
            this.ExternalFolderControl.OnTextChangedListener = null;
            this.ExternalFolderControl.OpenCallback = null;
            this.ExternalFolderControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ExternalFolderControl.SelectedPath = null;
            this.ExternalFolderControl.Size = new System.Drawing.Size(998, 32);
            this.ExternalFolderControl.StartPath = null;
            this.ExternalFolderControl.TabIndex = 16;
            this.ExternalFolderControl.TextBoxBottomMargin = 0;
            this.ExternalFolderControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.ExternalFolderControl.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.ExternalFolderControl.TextBoxFont = null;
            this.ExternalFolderControl.TextBoxTopMargin = 0;
            this.ExternalFolderControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // ProjectImagesCountControl
            // 
            this.ProjectImagesCountControl.BackColor = System.Drawing.Color.Transparent;
            this.ProjectImagesCountControl.Font = new System.Drawing.Font("Verdana", 12F);
            this.ProjectImagesCountControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.ProjectImagesCountControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectImagesCountControl.LabelText = "Project Images:";
            this.ProjectImagesCountControl.LabelWidth = 160;
            this.ProjectImagesCountControl.Location = new System.Drawing.Point(607, 88);
            this.ProjectImagesCountControl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ProjectImagesCountControl.Name = "ProjectImagesCountControl";
            this.ProjectImagesCountControl.Size = new System.Drawing.Size(222, 24);
            this.ProjectImagesCountControl.TabIndex = 15;
            this.ProjectImagesCountControl.ValueLabelColor = System.Drawing.Color.LemonChiffon;
            this.ProjectImagesCountControl.ValueLabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ProjectsCountControl
            // 
            this.ProjectsCountControl.BackColor = System.Drawing.Color.Transparent;
            this.ProjectsCountControl.Font = new System.Drawing.Font("Verdana", 12F);
            this.ProjectsCountControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.ProjectsCountControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectsCountControl.LabelText = "Projects:";
            this.ProjectsCountControl.LabelWidth = 92;
            this.ProjectsCountControl.Location = new System.Drawing.Point(334, 284);
            this.ProjectsCountControl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ProjectsCountControl.Name = "ProjectsCountControl";
            this.ProjectsCountControl.Size = new System.Drawing.Size(206, 26);
            this.ProjectsCountControl.TabIndex = 13;
            this.ProjectsCountControl.ValueLabelColor = System.Drawing.Color.LemonChiffon;
            this.ProjectsCountControl.ValueLabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // SolutionsCountControl
            // 
            this.SolutionsCountControl.BackColor = System.Drawing.Color.Transparent;
            this.SolutionsCountControl.Font = new System.Drawing.Font("Verdana", 12F);
            this.SolutionsCountControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.SolutionsCountControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolutionsCountControl.LabelText = "Solutions:";
            this.SolutionsCountControl.LabelWidth = 100;
            this.SolutionsCountControl.Location = new System.Drawing.Point(334, 88);
            this.SolutionsCountControl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SolutionsCountControl.Name = "SolutionsCountControl";
            this.SolutionsCountControl.Size = new System.Drawing.Size(206, 24);
            this.SolutionsCountControl.TabIndex = 11;
            this.SolutionsCountControl.ValueLabelColor = System.Drawing.Color.LemonChiffon;
            this.SolutionsCountControl.ValueLabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolutionsCountControl.Visible = false;
            // 
            // ItemsFoundControl
            // 
            this.ItemsFoundControl.BackColor = System.Drawing.Color.Transparent;
            this.ItemsFoundControl.Font = new System.Drawing.Font("Verdana", 12F);
            this.ItemsFoundControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.ItemsFoundControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsFoundControl.LabelText = "Images Found:";
            this.ItemsFoundControl.LabelWidth = 140;
            this.ItemsFoundControl.Location = new System.Drawing.Point(25, 88);
            this.ItemsFoundControl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ItemsFoundControl.Name = "ItemsFoundControl";
            this.ItemsFoundControl.Size = new System.Drawing.Size(252, 24);
            this.ItemsFoundControl.TabIndex = 9;
            this.ItemsFoundControl.ValueLabelColor = System.Drawing.Color.LemonChiffon;
            this.ItemsFoundControl.ValueLabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ProjectRootControl
            // 
            this.ProjectRootControl.BackColor = System.Drawing.Color.Transparent;
            this.ProjectRootControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProjectRootControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.Folder;
            this.ProjectRootControl.ButtonImage = ((System.Drawing.Image)(resources.GetObject("ProjectRootControl.ButtonImage")));
            this.ProjectRootControl.ButtonWidth = 48;
            this.ProjectRootControl.DisabledLabelColor = System.Drawing.Color.LightGray;
            this.ProjectRootControl.Editable = false;
            this.ProjectRootControl.EnabledLabelColor = System.Drawing.Color.LemonChiffon;
            this.ProjectRootControl.Filter = null;
            this.ProjectRootControl.Font = new System.Drawing.Font("Verdana", 12F);
            this.ProjectRootControl.HideBrowseButton = false;
            this.ProjectRootControl.LabelBottomMargin = 0;
            this.ProjectRootControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.ProjectRootControl.LabelFont = null;
            this.ProjectRootControl.LabelText = "Project Root:";
            this.ProjectRootControl.LabelTopMargin = 0;
            this.ProjectRootControl.LabelWidth = 160;
            this.ProjectRootControl.Location = new System.Drawing.Point(25, 32);
            this.ProjectRootControl.Name = "ProjectRootControl";
            this.ProjectRootControl.OnTextChangedListener = null;
            this.ProjectRootControl.OpenCallback = null;
            this.ProjectRootControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProjectRootControl.SelectedPath = null;
            this.ProjectRootControl.Size = new System.Drawing.Size(998, 32);
            this.ProjectRootControl.StartPath = null;
            this.ProjectRootControl.TabIndex = 6;
            this.ProjectRootControl.TextBoxBottomMargin = 0;
            this.ProjectRootControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.ProjectRootControl.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.ProjectRootControl.TextBoxFont = null;
            this.ProjectRootControl.TextBoxTopMargin = 0;
            this.ProjectRootControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::GitTrimmer.Properties.Resources.Deep_Black;
            this.ClientSize = new System.Drawing.Size(1064, 715);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.MoveButton);
            this.Controls.Add(this.SpaceSavedControl);
            this.Controls.Add(this.OrphanFilesControl);
            this.Controls.Add(this.ExternalFolderControl);
            this.Controls.Add(this.ProjectImagesCountControl);
            this.Controls.Add(this.ProjectFilesListBox);
            this.Controls.Add(this.ProjectsCountControl);
            this.Controls.Add(this.ProjectsListBox);
            this.Controls.Add(this.SolutionsCountControl);
            this.Controls.Add(this.SolutionsListBox);
            this.Controls.Add(this.ItemsFoundControl);
            this.Controls.Add(this.FilesListBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ProjectRootControl);
            this.Controls.Add(this.TopMarginPanel);
            this.Controls.Add(this.BottomMarginPanel);
            this.Controls.Add(this.RightMarginPanel);
            this.Controls.Add(this.LeftMarginPanel);
            this.Controls.Add(this.CompleteImage);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Git Trimmer";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.CompleteImage)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl ProjectRootControl;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ListBox FilesListBox;
        private DataJuggler.Win.Controls.LabelLabelControl ItemsFoundControl;
        private DataJuggler.Win.Controls.LabelLabelControl SolutionsCountControl;
        private System.Windows.Forms.ListBox SolutionsListBox;
        private DataJuggler.Win.Controls.LabelLabelControl ProjectsCountControl;
        private System.Windows.Forms.ListBox ProjectsListBox;
        private DataJuggler.Win.Controls.LabelLabelControl ProjectImagesCountControl;
        private System.Windows.Forms.ListBox ProjectFilesListBox;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl ExternalFolderControl;
        private DataJuggler.Win.Controls.LabelLabelControl OrphanFilesControl;
        private DataJuggler.Win.Controls.LabelLabelControl SpaceSavedControl;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.ProgressBar Graph;
        private System.Windows.Forms.PictureBox CompleteImage;
    }
}

