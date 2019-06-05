

#region using statements

using GitTrimmer.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace GitTrimmer.Objects
{

    #region class ProjectFile
    /// <summary>
    /// This class represents a file that is included in a C# Project.
    /// To be specific regarding this project, this means a project file that is a .jpg or .png.
    /// </summary>
    public class ProjectFile
    {
        
        #region Private Variables
        private string fullPath;
        private string name;
        private ImageTypeEnum imageType;
        private long size;
        private Guid projectId;
        private int solutionId;
        private bool isProjectFile;
        private bool isContent;
        #endregion

        #region Properties

            #region FullPath
            /// <summary>
            /// This property gets or sets the value for 'FullPath'.
            /// </summary>
            public string FullPath
            {
                get { return fullPath; }
                set { fullPath = value; }
            }
            #endregion
            
            #region HasProjectId
            /// <summary>
            /// This property returns true if the 'ProjectId' is set.
            /// </summary>
            public bool HasProjectId
            {
                get
                {
                    // initial value
                    bool hasProjectId = (this.ProjectId != Guid.Empty);
                    
                    // return value
                    return hasProjectId;
                }
            }
            #endregion
            
            #region ImageType
            /// <summary>
            /// This property gets or sets the value for 'ImageType'.
            /// </summary>
            public ImageTypeEnum ImageType
            {
                get { return imageType; }
                set { imageType = value; }
            }
            #endregion
            
            #region IsContent
            /// <summary>
            /// This property gets or sets the value for 'IsContent'.
            /// </summary>
            public bool IsContent
            {
                get { return isContent; }
                set { isContent = value; }
            }
            #endregion
            
            #region IsProjectFile
            /// <summary>
            /// This property gets or sets the value for 'IsProjectFile'.
            /// </summary>
            public bool IsProjectFile
            {
                get { return isProjectFile; }
                set { isProjectFile = value; }
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

            #region ProjectId
            /// <summary>
            /// This property gets or sets the value for 'ProjectId'.
            /// </summary>
            public Guid ProjectId
            {
                get { return projectId; }
                set { projectId = value; }
            }
            #endregion
            
            #region Size
            /// <summary>
            /// This property gets or sets the value for 'Size'.
            /// </summary>
            public long Size
            {
                get { return size; }
                set { size = value; }
            }
            #endregion
            
            #region SolutionId
            /// <summary>
            /// This property gets or sets the value for 'SolutionId'.
            /// </summary>
            public int SolutionId
            {
                get { return solutionId; }
                set { solutionId = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
