

#region using statements

using DataJuggler.Core.UltimateHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace GitTrimmer.Objects
{

    #region class Project
    /// <summary>
    /// This class represents a GitTrimmer project.
    /// </summary>
    public class Project
    {
        
        #region Private Variables
        private string rootFolder;
        private string externalFolder;
        private List<Solution> solutions;
        private List<ProjectFile> allFiles;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'Project' object.
        /// </summary>
        public Project()
        {
            // Perform initializations for this object
            Init();
        }
        #endregion
        
        #region Methods
            
            #region FindProject(ProjectFile projectFile)
            /// <summary>
            /// This method returns the Project
            /// </summary>
            public VSProject FindProject(ProjectFile projectFile)
            {
                // initial value
                VSProject project = null;

                // if the value for HasSolutions is true
                if (HasSolutions)
                {
                    // Iterate the collection of Solution objects
                    foreach (Solution solution in Solutions)
                    {
                        // If the value for the property solution.HasProjects is true
                        if (solution.HasProjects)
                        {
                            // iterate the projects
                            foreach (VSProject tempProject in solution.Projects)
                            {
                                // If the value for the property tempProject.HasFiles is true
                                if (tempProject.HasFiles)    
                                {
                                    // iterate the projectFile                                    
                                    foreach (ProjectFile file in tempProject.Files)
                                    {
                                        // if the full paths match
                                        if (TextHelper.IsEqual(file.FullPath, projectFile.FullPath))
                                        {
                                            // set the return value
                                            project = tempProject;

                                            // break out of the loop
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                
                // return value
                return project;
            }
            #endregion
            
            #region Init()
            /// <summary>
            /// This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Create the child objects
                this.AllFiles = new List<ProjectFile>();
                this.Solutions = new List<Solution>();
            }
            #endregion
            
        #endregion
        
        #region Properties
            
            #region AllFiles
            /// <summary>
            /// This property gets or sets the value for 'AllFiles'.
            /// </summary>
            public List<ProjectFile> AllFiles
            {
                get { return allFiles; }
                set { allFiles = value; }
            }
            #endregion
            
            #region ExternalFolder
            /// <summary>
            /// This property gets or sets the value for 'ExternalFolder'.
            /// </summary>
            public string ExternalFolder
            {
                get { return externalFolder; }
                set { externalFolder = value; }
            }
            #endregion
            
            #region HasAllFiles
            /// <summary>
            /// This property returns true if this object has an 'AllFiles'.
            /// </summary>
            public bool HasAllFiles
            {
                get
                {
                    // initial value
                    bool hasAllFiles = (this.AllFiles != null);
                    
                    // return value
                    return hasAllFiles;
                }
            }
            #endregion
            
            #region HasExternalFolder
            /// <summary>
            /// This property returns true if the 'ExternalFolder' exists.
            /// </summary>
            public bool HasExternalFolder
            {
                get
                {
                    // initial value
                    bool hasExternalFolder = (!String.IsNullOrEmpty(this.ExternalFolder));
                    
                    // return value
                    return hasExternalFolder;
                }
            }
            #endregion
            
            #region HasOrphanFiles
            /// <summary>
            /// This property returns true if this object has an 'OrphanFiles'.
            /// </summary>
            public bool HasOrphanFiles
            {
                get
                {
                    // initial value
                    bool hasOrphanFiles = (this.OrphanFiles != null);
                    
                    // return value
                    return hasOrphanFiles;
                }
            }
            #endregion
            
            #region HasRootFolder
            /// <summary>
            /// This property returns true if the 'RootFolder' exists.
            /// </summary>
            public bool HasRootFolder
            {
                get
                {
                    // initial value
                    bool hasRootFolder = (!String.IsNullOrEmpty(this.RootFolder));
                    
                    // return value
                    return hasRootFolder;
                }
            }
            #endregion
            
            #region HasSolutions
            /// <summary>
            /// This property returns true if this object has a 'Solutions'.
            /// </summary>
            public bool HasSolutions
            {
                get
                {
                    // initial value
                    bool hasSolutions = (this.Solutions != null);
                    
                    // return value
                    return hasSolutions;
                }
            }
            #endregion

            #region OrphanFiles
            /// <summary>
            /// This read only property returns the files the All Files that are not in a Project File
            /// </summary>
            public List<ProjectFile> OrphanFiles
            {
                get
                {
                    // initial value
                    List<ProjectFile> orphanFiles = new List<ProjectFile>();

                    // if the value for HasAllFiles is true
                    if (HasAllFiles)
                    {
                        // Iterate the collection of ProjectFile objects
                        foreach (ProjectFile file in AllFiles)
                        {
                            // Attempt to find a project for this file
                            VSProject project = FindProject(file);

                            // if the project exists
                            if (NullHelper.Exists(project))
                            {
                                // set to true
                                file.IsProjectFile = true;

                                // set the ProjectId
                                file.ProjectId = project.Id;
                            }
                            else
                            {
                                // Add this file
                                orphanFiles.Add(file);
                            }
                        }
                    }
                    
                    // return value
                    return orphanFiles;
                }
            }
            #endregion

            #region RootFolder
            /// <summary>
            /// This property gets or sets the value for 'RootFolder'.
            /// </summary>
            public string RootFolder
            {
                get { return rootFolder; }
                set { rootFolder = value; }
            }
            #endregion
            
            #region Solutions
            /// <summary>
            /// This property gets or sets the value for 'Solutions'.
            /// </summary>
            public List<Solution> Solutions
            {
                get { return solutions; }
                set { solutions = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
