

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace GitTrimmer.Enumerations
{

    #region ImageTypeEnum : int
    /// <summary>
    /// This enumeration is used to identity if an image is a Jpeg or a Png type file.
    /// </summary>
    public enum ImageTypeEnum : int
    {
        Unknown = 0,
        Jpeg = 1,
        Png = 2
    }
    #endregion

}
