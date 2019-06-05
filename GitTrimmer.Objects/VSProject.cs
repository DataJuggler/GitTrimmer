

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace GitTrimmer.Objects
{

    #region class VSProject
    /// <summary>
    /// This class represents a VisualStudio project; specifically a C# project.
    /// </summary>
    public class VSProject
    {
        
        #region Private Variables
        private List<ProjectFile> files;
        private Solution solution;
        private string path;
        private string name;
        private Guid id;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'VSProject' object.
        /// </summary>
        public VSProject()
        {   
            // Create a new collection of 'ProjectFile' objects.
            Files = new List<ProjectFile>();
        }
        #endregion
        
        #region Properties
            
            #region Files
            /// <summary>
            /// This property gets or sets the value for 'Files'.
            /// </summary>
            public List<ProjectFile> Files
            {
                get { return files; }
                set { files = value; }
            }
            #endregion
            
            #region HasFiles
            /// <summary>
            /// This property returns true if this object has a 'Files'.
            /// </summary>
            public bool HasFiles
            {
                get
                {
                    // initial value
                    bool hasFiles = (this.Files != null);
                    
                    // return value
                    return hasFiles;
                }
            }
            #endregion
            
            #region HasName
            /// <summary>
            /// This property returns true if the 'Name' exists.
            /// </summary>
            public bool HasName
            {
                get
                {
                    // initial value
                    bool hasName = (!String.IsNullOrEmpty(this.Name));
                    
                    // return value
                    return hasName;
                }
            }
            #endregion
            
            #region HasPath
            /// <summary>
            /// This property returns true if the 'Path' exists.
            /// </summary>
            public bool HasPath
            {
                get
                {
                    // initial value
                    bool hasPath = (!String.IsNullOrEmpty(this.Path));
                    
                    // return value
                    return hasPath;
                }
            }
            #endregion
            
            #region HasSolution
            /// <summary>
            /// This property returns true if this object has a 'Solution'.
            /// </summary>
            public bool HasSolution
            {
                get
                {
                    // initial value
                    bool hasSolution = (this.Solution != null);
                    
                    // return value
                    return hasSolution;
                }
            }
            #endregion
            
            #region Id
            /// <summary>
            /// This property gets or sets the value for 'Id'.
            /// </summary>
            public Guid Id
            {
                get { return id; }
                set { id = value; }
            }
            #endregion
            
            #region Name
            /// <summary>
            /// This property gets or sets the value for 'Name'.
            /// </summary>
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            #endregion
            
            #region Path
            /// <summary>
            /// This property gets or sets the value for 'Path'.
            /// </summary>
            public string Path
            {
                get { return path; }
                set { path = value; }
            }
            #endregion
            
            #region Solution
            /// <summary>
            /// This property gets or sets the value for 'Solution'.
            /// </summary>
            public Solution Solution
            {
                get { return solution; }
                set { solution = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
