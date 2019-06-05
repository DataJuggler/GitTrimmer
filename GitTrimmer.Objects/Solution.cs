

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace GitTrimmer.Objects
{

    #region class Solution
    /// <summary>
    /// This class represents a Visual Studio Solution
    /// </summary>
    public class Solution
    {
        
        #region Private Variables
        private List<VSProject> projects;
        private string path;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'Solution' object.
        /// </summary>
        public Solution()
        {
            // Create a new collection of 'VSProject' objects.
            Projects = new List<VSProject>();
        }
        #endregion
        
        #region Properties
            
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
            
            #region HasProjects
            /// <summary>
            /// This property returns true if this object has a 'Projects'.
            /// </summary>
            public bool HasProjects
            {
                get
                {
                    // initial value
                    bool hasProjects = (this.Projects != null);
                    
                    // return value
                    return hasProjects;
                }
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
            
            #region Projects
            /// <summary>
            /// This property gets or sets the value for 'Projects'.
            /// </summary>
            public List<VSProject> Projects
            {
                get { return projects; }
                set { projects = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
