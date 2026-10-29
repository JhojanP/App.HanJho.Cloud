using System;
using System.Collections.Generic;
using System.Text;

namespace App.HanJho.Cloud.Presenters
{
    public interface IPresenter<FormatDataType>
    {
         public FormatDataType Content { get; }

    }
}
