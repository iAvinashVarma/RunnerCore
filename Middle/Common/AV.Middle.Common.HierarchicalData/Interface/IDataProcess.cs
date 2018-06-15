using AV.Middle.Common.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Common.HierarchicalData.Interface
{
    public interface IDataProcess
    {
		FileModel FileModel { get; set; }

		HierarchicalDataModel GetHierarchicalDataModel();
    }
}
